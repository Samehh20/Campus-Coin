using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
//Enum for Payment Request
namespace CampusCoin.Models
{
    public enum PaymentRequestStatusEnum
    {
        Pending=1,
        Approved,
        Cancelled
    }
}
