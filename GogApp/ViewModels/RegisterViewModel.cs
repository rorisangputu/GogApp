using System;
using System.ComponentModel.DataAnnotations;

namespace GogApp.ViewModels;

public class RegisterViewModel
{
    [Display(Name = "Email Address")]
    [Required(ErrorMessage = "Email address is required")]
    public string? EmailAddress { get; set; }

    [Display(Name = "Name")]
    [Required(ErrorMessage = "Name is required")]
    public string? Name { get; set; }

    [Required]
    [DataType(DataType.Password)]
    public string? Password { get; set; }

    [Display(Name = "Confirm password")]
    [Required(ErrorMessage = "Confirm Password is required")]
    [DataType(DataType.Password)]
    [Compare("Password", ErrorMessage = "Password do not match")]
    public string? ConfirmPassword { get; set; }

}