using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace E_commerce1.ViewModels
{
    public class RoleViewModel
    {
        [Required(ErrorMessage ="This field is required")]
        [MaxLength(20,ErrorMessage ="Role NAme Must Be Less Than 20")]
        [Display(Name ="Role Name")]
        [MinLength(3,ErrorMessage ="Role Name can't be less than 3")]
        [Remote(action: "RoleExsist", controller:"role",AdditionalFields =nameof(RoleName) ,ErrorMessage ="role name is exsist")]
        public string RoleName { get; set; }
    }
}
