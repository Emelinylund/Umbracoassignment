using System.ComponentModel.DataAnnotations;

namespace UmbracoProject.ViewModels;

public class QuestionFormViewModel
{
    [Required(ErrorMessage = "Name is required.")]
    [Display(Name = "Name")]
    public string Name { get; set; } = null!;

    [Required(ErrorMessage = "Email is required.")]
    [Display(Name = "Email")]
    [RegularExpression(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$", ErrorMessage = "Invalid email address.")]
    public string Email { get; set; } = null!;

    [Required(ErrorMessage = "Please enter a question")]
    [Display(Name = "Question")]

    public string Question { get; set; } = null!;
}
