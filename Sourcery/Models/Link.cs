using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sourcery.Models
{
    public class Link
    {
        public int ID { get; set; }
        public string LinkAddress { get; set; }
        public DateTime AddDate { get; set; }
        public int Score { get; set; }
    }
}
