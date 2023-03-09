using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Components;

namespace LibraryMVC.Models
{
    public class District
    {
        public short Id { get; set; }

        [Column(TypeName = "NCHAR(20)")]
        [Required(ErrorMessage = "İsim girmek zorunludur!")]
        [StringLength(20, MinimumLength = 2, ErrorMessage = "2-20 arası karakter olabilir!")]
        [Display(Name = "İsim")]
        public string Name { get; set; }

        [Range(1, 5000000, ErrorMessage = "1-5.000.000 arası bir değer giriniz!")]
        [Required(ErrorMessage = "Nüfus girmek zorunludur!")]
        [Display(Name = "Nüfus")]
        public int Population { get; set; }

        [Required(ErrorMessage = "Plaka kodu girmek zorunludur!")]
        [Display(Name = "Şehir")]
        public byte CityId { get; set; }

        [ForeignKey("CityId")]
        [Display(Name = "Şehir")]
        public City? City { get; set; }

    }
}
