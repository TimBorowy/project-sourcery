using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Sourcery.Models
{
    public class LinkTag
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey("Link")]
        public int LinkId { get; set; }

        public Link Link { get; set; }

        [ForeignKey("Tag")]
        public int TagId { get; set; }

        public Tag Tag { get; set; }
    }
}
