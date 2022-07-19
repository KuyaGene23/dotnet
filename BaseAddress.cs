using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sabio.Models.Domain.Addresses
{
    public class BaseAddress
    {
        public int Id { get; set; }
        public int SuiteNumber { get; set; }
        public string PostalCode { get; set; }

    }
}
