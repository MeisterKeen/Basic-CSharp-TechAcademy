using NewsletterAppMVC;
using NewsletterAppMVC.ViewModels;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NewsletterAppMVC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }



        // PASSING INPUTS FROM A WEB FORM INTO A SQL DATABASE::
        // We define our connection string (because it's huge and we use it as an argument)
        //private readonly string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Newsletter;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        // Or we don't, because we're using EntityFramework now! :D :D :D
        [HttpPost]
        public ActionResult SignUp(string firstName, string lastName, string emailAddress)
        {
            // First, we're taking the strings (named and defined in the .cshtml file) and using them as parameters for this Controller method:
            // NOTE: this is MVC automatically connecting the html forms to these variables! The names are the same, so it automagically relates them.

            // An if/else just to check that the string variables actually caught data from the html form:
            if (string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(lastName) || string.IsNullOrEmpty(emailAddress))
            {
                return View("~/Views/Shared/Error.cshtml");
            }
            else
            {
                // Now, we have data in our string variables. Next we have to get that data into our database.

                using (NewsletterEntities1 db = new NewsletterEntities1())
                {
                    // Make a SignUo object, map our variables to the properties:
                    var signup = new SignUp();
                    signup.FirstName = firstName;
                    signup.LastName = lastName;
                    signup.EmailAddress = emailAddress;

                    // Add and save changes. THAT'S IT!
                    db.SignUps.Add(signup);
                    db.SaveChanges();
                }


                    //   REPLACED ABOVE USING ENTITYFRAMEWORK:
                    ////////////////////////////////////////////////////////////////////////
                    //// Here's our actual insert query string, we're speaking SQL and Razor C# here:
                    //string queryString = @"INSERT INTO SignUps (FirstName, LastName, EmailAddress) VALUES
                    //                       (@FirstName, @LastName, @EmailAddress)";

                    //// We use "using" so we let go of this resource (and prevent injections) when we're done executing this code block,
                    //// And we define our SqlConnection object using our connection string
                    //using (SqlConnection connection = new SqlConnection(connectionString))
                    //{
                    //    // Here we're enacting a SqlCommand object using our query string as the command, and passing in the connection object:
                    //    SqlCommand command = new SqlCommand(queryString, connection);
                    //    // And here we're using this command object every time we add these converted strings as parameters:
                    //    command.Parameters.Add("@FirstName", SqlDbType.VarChar);
                    //    command.Parameters.Add("@LastName", SqlDbType.VarChar);
                    //    command.Parameters.Add("@EmailAddress", SqlDbType.VarChar);
                    //    // Two things to note: VarChars are not the same as Strings! We have to convert these, they don't directly map from C# to SQL
                    //    // Second: this is called "parameterizing" the database inputs, passing them as strictly-defined strings converted into VarChars.
                    //    // This helps prevent SQL injections. Not perfect protection, but it helps. Consider this a standard way to handle web forms.

                    //    // Now we actually pass the values (arguments) INTO the parameters we just defined above:
                    //    command.Parameters["@Firstname"].Value = firstName;
                    //    command.Parameters["@LastName"].Value = lastName;
                    //    command.Parameters["@EmailAddress"].Value = emailAddress;

                    //    // Now we open the connection:
                    //    connection.Open();
                    //    // We execute our INSERT, which is technically not a query, so...
                    //    command.ExecuteNonQuery();
                    //    // And we close the connection.
                    //    connection.Close();

                    //}
                    //////////////////////////////////////////////////////////////////////////


                    return View("Success");
            }
        }

    }
}