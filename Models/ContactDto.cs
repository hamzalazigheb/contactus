using System.ComponentModel.DataAnnotations; // Importing the namespace for data annotations, which provides validation attributes.

namespace WebApplication1.Models // Defining the namespace for the project to organize the code logically.
{
    /// <summary>
    /// Represents a data transfer object for contact form data.
    /// </summary>
    public class ContactDto // Declaring the ContactDto class to model the data structure for a contact form.
    {
        [Required(ErrorMessage = "The first name is required")] // Ensures that the FirstName property must have a value, with a custom error message.
        public string FirstName { get; set; } = ""; // Represents the first name of the contact, initialized with an empty string.

        [Required(ErrorMessage = "The last name is required")] // Ensures that the LastName property must have a value, with a custom error message.
        public string LastName { get; set; } = ""; // Represents the last name of the contact, initialized with an empty string.

        [Required(ErrorMessage = "The email is required")] // Ensures that the Email property must have a value, with a custom error message.
        [EmailAddress] // Validates that the provided email is in a correct email address format.
        public string Email { get; set; } = ""; // Represents the email address of the contact, initialized with an empty string.

        [Required(ErrorMessage = "The message is required")] // Ensures that the Message property must have a value, with a custom error message.
        public string Message { get; set; } = ""; // Represents the message provided by the contact, initialized with an empty string.

        public string EmailAddress { get; set; } = "contact@beststore.com"; // Represents the default email address for contact, initialized to a predefined value.

        public string Address { get; set; } = "New York, USA"; // Represents the default address for the business, initialized to a predefined value.
    }
}
