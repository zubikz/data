using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace practice1.Models
{
    public class student
    {
        [Key]
        public int Id { get;
            set;
        }
        public string Name
        {
            get;
            set;
        }
        public int Age { get;
            set;
        }
        public string state
        {
            get;set;
        }

        public string Country
        {
            get;
            set;
        }
    }
}