using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Models
{
    public class Customer
    {
        public int CustomerId { get; set; }
        public int CustomerNumber { get; set; }
        public string CustomerName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Gender { get; set; }
    }
}
