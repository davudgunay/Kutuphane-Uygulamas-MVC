using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Components;

namespace LibraryMVC.Models
{
    public class Library
    {
        public int Id { get; set; }

        [Display(Name = "Kütüphane Adı")]
        [Required(ErrorMessage = "İsim girmek zorunludur!")]
        [StringLength(50, MinimumLength = 5, ErrorMessage = "5-50 arası karakter olabilir!")]
        public string Name { get; set; }

        [Display(Name = "Kitap Adeti")]
        [Required(ErrorMessage = "Kitap adeti girmek zorunludur!")]
        public int BookCount { get; set; }

        [Display(Name = "Ziyaretçi Kapasitesi")]
        [Required(ErrorMessage = "Kapasite girmek zorunludur!")]
        [Range(1, 500, ErrorMessage = "1-500 arası bir değer giriniz!")]
        public short Capacity { get; set; }

        [Display(Name = "Kuruluş Tarihi")]
        [Required(ErrorMessage = "Tarih girmek zorunludur!")]
        [Column(TypeName = "date")]
        public DateTime EstablishmentDate { get; set; }

        [Display(Name = "İlçe")]
        public short DistrictId { get; set; }

        [ForeignKey("DistrictId")]
        [Display(Name = "İlçe")]
        public District? District { get; set; }
    }
}
