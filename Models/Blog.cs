using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace My_Blog_API.Models
{
    public class Blog
    {

        [Key]
        public int Blog_ID { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
    }
}
