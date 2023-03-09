using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Components;

namespace LibraryMVC.Models
{
    public class City
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Required(ErrorMessage = "Plaka kodu zorunludur!")]
        [Range(1, 81, ErrorMessage = "1-81 arası bir değer giriniz!")]
        [Display(Name = "Plaka Kodu")]
        public byte PlateCode { get; set; }

        [Column(TypeName = "NCHAR")]
        [StringLength(20, MinimumLength =3 ,ErrorMessage = "3-20 arası karakter olabilir!")]
        [Required(ErrorMessage = "İsim girmek zorunludur!")]
        [Display(Name = "İsim")]
        public string Name { get; set; }

    }
}