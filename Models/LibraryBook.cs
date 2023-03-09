using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Components;

namespace LibraryMVC.Models
{
    public class LibraryBook
    {
        [Column(TypeName = "nchar(13)")]
        [Required(ErrorMessage = "ISBN girmek zorunludur!")]
        [StringLength(13, MinimumLength = 13, ErrorMessage = "13 karakterli olmalıdır!")]
        public string ISBN { get; set; }

        [Required(ErrorMessage = "Kütüphane girmek zorunludur!")]
        [Display(Name = "Kütüphane")]
        public int LibraryId { get; set; }

        [Column(TypeName = "nchar(5)")]
        [Required(ErrorMessage = "Dolap girmek zorunludur!")]
        [Display(Name = "Dolap")]
        [StringLength(5, ErrorMessage = "En fazla 5 karakterli olmalıdır!")]
        public string Cabinet { get; set; }

        [Column(TypeName = "nchar(5)")]
        [Required(ErrorMessage = "Raf girmek zorunludur!")]
        [Display(Name = "Raf")]
        [StringLength(5, ErrorMessage = "En fazla 5 karakterli olmalıdır!")]
        public string Shelf { get; set; }

        [Required(ErrorMessage = "Adet girmek zorunludur!")]
        [Display(Name = "Adet")]
        [Range(1, 20, ErrorMessage = "1-20 arası bir değer giriniz!")]
        public byte Amount { get; set; }

        [ForeignKey("LibraryId")]
        [Display(Name = "Kütüphane")]
        public Library? Library { get; set; }

        [ForeignKey("ISBN")]
        [Display(Name = "Kitap")]
        public Book? Book { get; set; }

    }
}
