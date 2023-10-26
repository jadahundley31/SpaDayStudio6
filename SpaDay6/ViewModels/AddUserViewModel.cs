using System;
using System.ComponentModel.DataAnnotations;

namespace SpaDay6.ViewModels
{
	public class AddUserViewModel
	{
		[Required(ErrorMessage = "Username is required")]
		[StringLength(15, MinimumLength = 5, ErrorMessage = "Username must be between 5 and 15 characters long")]
		public string? Username { get; set; }

		[Required(ErrorMessage = "Password is required")]
		[StringLength(20, MinimumLength = 6, ErrorMessage = "Sorry, the given password is too short. It must be at least 6 characters long")]
		public string? Password { get; set; }

		[Required(ErrorMessage = "Password doesn't match")]
		[StringLength(20, MinimumLength = 6)]
		public string? VerifyPassword { get; set; }

		[EmailAddress]
        public string? Email { get; set; }
    }
}

