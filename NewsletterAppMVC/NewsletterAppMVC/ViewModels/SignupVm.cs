using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

// Models map exactly to the database.
// ViewModels map to models -- ViewModels select those model items you want viewed!

namespace NewsletterAppMVC.ViewModels
{
    public class SignupVm
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public int Id { get; set; }

    }
}