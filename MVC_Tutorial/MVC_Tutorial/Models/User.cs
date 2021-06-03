using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC_Tutorial.Models
{
    public class User
    {
        public int Id { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public int age { get; set; }
    }
}