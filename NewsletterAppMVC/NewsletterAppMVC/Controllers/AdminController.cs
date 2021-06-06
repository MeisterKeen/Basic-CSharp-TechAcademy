using NewsletterAppMVC.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace NewsletterAppMVC.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        public ActionResult Index()
        {
            // We're using NewsletterEntities from our entity Context.cs file
            using (NewsletterEntities1 db = new NewsletterEntities1())
            {
                // The SignUps property represents all of the records in our table, but we filter any that are Removed.
                // Here are two ways to do that:
                //var signups = db.SignUps.Where(x => x.Removed == null).ToList();
                var signups = (from c in db.SignUps
                               where c.Removed == null
                               select c).ToList();
                // Instantiate a list of view model SignupVm objects:
                var signupVms = new List<SignupVm>();
                foreach (var signup in signups)
                {
                    // Maps the SignUps to our view model:
                    var signupVm = new SignupVm();
                    signupVm.Id = signup.Id;
                    signupVm.FirstName = signup.FirstName;
                    signupVm.LastName = signup.LastName;
                    signupVm.EmailAddress = signup.EmailAddress;
                    signupVms.Add(signupVm);
                }

                return View(signupVms);
            }

            //       THIS CODE REPLACED USING ENTITYFRAMEWORK
            ////////////////////////////////////////////////////////
            //string queryString = @"SELECT Id, FirstName, LastName, EmailAddress, SocSecNum from SignUps";
            //List<NewsletterSignUp> signups = new List<NewsletterSignUp>();

            //using (SqlConnection connection = new SqlConnection(connectionString))
            //{
            //    SqlCommand command = new SqlCommand(queryString, connection);

            //    connection.Open();

            //    SqlDataReader reader = command.ExecuteReader();

            //    while (reader.Read())
            //    {
            //        var signup = new NewsletterSignUp();
            //        signup.Id = Convert.ToInt32(reader["Id"]);
            //        signup.FirstName = Convert.ToString(reader["FirstName"]);
            //        signup.LastName = Convert.ToString(reader["LastName"]);
            //        signup.EmailAddress = Convert.ToString(reader["EmailAddress"]);
            //        signup.SocSecNum = reader["SocSecNum"].ToString();

            //        signups.Add(signup);
            //    }
            //}
            ////////////////////////////////////////////////////////
        }

        public ActionResult Unsubscribe(int Id)
        {
            using (NewsletterEntities1 db = new NewsletterEntities1())
            {
                var signup = db.SignUps.Find(Id);
                signup.Removed = DateTime.Now;
                db.SaveChanges();
            }
            return RedirectToAction("Index");
        }

    }
}