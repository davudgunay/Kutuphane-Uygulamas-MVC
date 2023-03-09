using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Components;

namespace LibraryMVC.Models
{
    public class Author
    {

        public long Id { get; set; }

        [Column(TypeName = "nchar(100)")]
        [Required(ErrorMessage = "İsim girmek zorunludur!")]
        [StringLength(100, ErrorMessage = "En fazla 100 karakter olabilir!")]
        [Display(Name = "İsim")]
        public string Name { get; set; }

        [Column(TypeName ="date")]
        [Display(Name = "Doğum Tarihi(opsiyonel)")]
        public DateTime? BirthDate { get; set; }

        [Column(TypeName = "date")]
        [Display(Name = "Ölüm Tarihi(opsiyonel)")]
        public DateTime? DeathDate { get; set; }

        [Display(Name = "Cinsiyet(opsiyonel)")]
        public bool? Gender { get; set; }

    }
}
