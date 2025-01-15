using Microsoft.AspNetCore.Mvc; // Importing the namespace to enable ASP.NET Core MVC functionality, including controllers and actions.
using WebApplication1.Models; // Importing the namespace to access the ContactDto model class.

namespace WebApplication1.Controllers // Defining the namespace to logically organize the code for the application's controllers.
{
    /// <summary>
    /// Controller responsible for handling contact-related actions.
    /// </summary>
    public class ContactController : Controller // Declaring the ContactController class, which inherits from the base Controller class.
    {
        private readonly string email = "contact@beststore.com"; // Defining a private constant for the default contact email address.
        private readonly string address = "New York, USA"; // Defining a private constant for the default business address.

        /// <summary>
        /// Handles HTTP GET requests for the Contact page.
        /// </summary>
        /// <returns>Returns the default view for the Contact page.</returns>
        public IActionResult Index() // Action method to handle GET requests to display the Contact page.
        {
            ViewData["EmailAddress"] = email; // Assigns the email address to the ViewData dictionary for use in the view.
            ViewBag.Address = address; // Assigns the address to the ViewBag for dynamic access in the view.
            return View(); // Returns the default view associated with this action.
        }

        /// <summary>
        /// Handles HTTP POST requests for the Contact page.
        /// Processes the form data submitted by the user.
        /// </summary>
        /// <param name="model">The ContactDto object containing form data submitted by the user.</param>
        /// <returns>Returns the view with appropriate success or error messages.</returns>
        [HttpPost] // Specifies that this action responds to HTTP POST requests.
        public IActionResult Index(ContactDto model) // Action method to handle POST requests and process the submitted contact form.
        {
            ViewData["EmailAddress"] = email; // Reassigns the email address to ViewData for use in the view.
            ViewBag.Address = address; // Reassigns the address to the ViewBag for dynamic access in the view.

            if (!ModelState.IsValid) // Checks if the submitted model data fails validation rules.
            {
                return View(model); // Returns the same view with the submitted data and validation error messages.
            }

            // Placeholder for storing the contact data in the database.
            // This part can be replaced with database integration logic.

            ViewBag.SuccessMessage = "The message has been sent successfully"; // Sets a success message to be displayed in the view.
            ModelState.Clear(); // Clears the model state to reset the form fields after successful submission.
            return View(); // Returns the default view for the Contact page.
        }
    }
}
