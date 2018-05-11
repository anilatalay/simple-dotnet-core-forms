using System.ComponentModel.DataAnnotations;

namespace SimpleForms.Web.Models
{
    public class ContactFormModel
    {
        [Required(ErrorMessage = "Alan zorunlu.")]
        public string Name { get; set; }
        
        [Required(ErrorMessage = "Alan zorunlu.")]
        public string SurName { get; set; }
        
        [Required(ErrorMessage = "Alan zorunlu.")]
        [EmailAddress(ErrorMessage = "Email düzgün olmalı.")]
        public string Email { get; set; }
        
        public string Content { get; set; }
    }
}