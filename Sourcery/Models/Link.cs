using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Sourcery.Models
{
    public class Link
    {
        [Key]
        public int Id { get; set; }
        public string LinkAddress { get; set; }
        public DateTime AddDate { get; set; }
        public int Score { get; set; }

        [ForeignKey("Category")]
        public int CategoryId { get; set; }

        public Category Category { get; set; }

        public List<LinkTag> Tags { get; set; }
    }
}
