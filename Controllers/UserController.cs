using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using CampusCoin.Models;
using CampusCoin.Models.Repositories;
using CampusCoin.ViewModels;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CampusCoin.Controllers
{
    public class UserController : Controller
    {
        private readonly ICampusCoinRepository<DepositTransaction> _depositTransactionsRepository;
        private readonly IUserDbRepository _userRepository;
        private readonly IWalletDbRepository _walletRepository;
        // private readonly ICampusCoinRepository<ManagerialBranch> _managerialBranchRepository;
        //private readonly ICampusCoinRepository<DepositTransactionType> _depositTransactionTypeRepository;
        private readonly IHostingEnvironment hosting;

        public UserController(ICampusCoinRepository<DepositTransaction> depositTransactionsRepository,
           IUserDbRepository userRepository,
           IWalletDbRepository walletRepository,
           //ICampusCoinRepository<ManagerialBranch> managerialBranchRepository,
           // ICampusCoinRepository<DepositTransactionType> depositTransactionTypeRepository,
           IHostingEnvironment hosting)
        {
            this._depositTransactionsRepository = depositTransactionsRepository;
            this._userRepository = userRepository;
            this._walletRepository = walletRepository;
            //this._managerialBranchRepository = managerialBranchRepository;
           // this._depositTransactionTypeRepository = depositTransactionTypeRepository;
            this.hosting = hosting;
        }
        // GET: Wallet
        public ActionResult Index()
        {
            var Users = _userRepository.List();
            return View(Users);
        }

        // GET: Wallet/5
        public ActionResult Details(int id)
        {
            var deposit = _depositTransactionsRepository.Find(id);

            return View(deposit);
        }

        // GET: User/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: DepositTransaction/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(User user)
        {
            if (ModelState.IsValid)
            {
                try
                {
                     Guid userId=  _userRepository.AddUser(user);
                     Guid walletId = _walletRepository.AddWallet(userId);
                    var addedUser = _userRepository.FindById(userId);
                    addedUser.WalletId = walletId;
                    _userRepository.UpdateById(userId, addedUser);
                    return RedirectToAction(nameof(Index));
                }
                catch
                {
                    return View();
                }
            }  
            return View();
        }

        // GET: Wallet/Edit/5
        public ActionResult Edit(int id)
        {
            var depositTransaction = _depositTransactionsRepository.Find(id);

            var viewModel = new DepositWalletViewModel
            {
                Amount = depositTransaction.Amount,
                BankAccountNumber = depositTransaction.BankAccountNumber,
                CreditTransactionTypeId = depositTransaction.DepositTransactionTypeId,
                DepositId = depositTransaction.Id,
                ManagerialBranchId=depositTransaction.ManagerialBranchId,
                UserSSN=depositTransaction.Wallet.User.SSN,
            };

            return View(viewModel);
        }

        // POST: deposit-transaction/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(DepositWalletViewModel viewModel)
        {
            try
            {
                var user = _userRepository.FindBySsn(viewModel.UserSSN);
                DepositTransaction depositTransaction = new DepositTransaction
                {
                    Amount = viewModel.Amount,
                    BankAccountNumber = viewModel.BankAccountNumber,
                    ManagerialBranchId = viewModel.ManagerialBranchId,
                    WalletId=user.WalletId,
                    Id = viewModel.DepositId,
                };

                _depositTransactionsRepository.Update(viewModel.DepositId, depositTransaction);

                return RedirectToAction(nameof(Index));
            }
            catch (Exception)
            {
                return View();
            }
        }

        // GET: deposit-transaction/Delete/5
        public ActionResult Delete(int id)
        {
            var depositTransaction = _depositTransactionsRepository.Find(id);

            return View(depositTransaction);
        }

        // POST: deposit-transaction/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult ConfirmDelete(int id)
        {
            try
            {
                // TODO: Add delete logic here
                _depositTransactionsRepository.Delete(id);

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        List<ManagerialBranch> FillBranchSelectList()
        {
            var branches = new List<ManagerialBranch> { new ManagerialBranch {Id=1, BranchName="test"} };//_managerialBranchRepository.List().ToList();
            branches.Insert(0, new ManagerialBranch { Id = -1, BranchName = "--- Please select your branch ---" });

            return branches;
        }
        List<DepositTransactionType> FillDepositTypesSelectList()
        {
            var depositTransactionTypes = new List<DepositTransactionType> { new DepositTransactionType { Id=3,Title="Bank"}, new DepositTransactionType { Id = 2,Title="Cash" } };// _depositTransactionTypeRepository.List().ToList();
            //branches.Insert(0, new DepositTransactionType { Id = -1, Title = "--- Please select an author ---" });

            return depositTransactionTypes;
        }

        DepositWalletViewModel GetAllSelectList()
        {
            var vmodel = new DepositWalletViewModel
            {
                ManagerialBranchs = FillBranchSelectList(),
                CreditTransactionTypes = FillDepositTypesSelectList()
            };

            return vmodel;
        }

       

        public ActionResult Search(string term)
        {
            var result = _depositTransactionsRepository.Search(term);

            return View("Index", result);
            
        }

    }
}