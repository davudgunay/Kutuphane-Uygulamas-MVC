using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Linq;
using Xunit.Sdk;

namespace LibraryMVC.Models
{
    public class Employee
    {

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Range(10000000000, 99999999999, ErrorMessage = "11 rakam giriniz!")]
		[Display(Name = "TC No")]
		public long Id { get; set; }

        [Column(TypeName = "nchar(100)")]
        [Required(ErrorMessage = "İsim girmek zorunludur!")]
        [StringLength(100, ErrorMessage = "En fazla 100 karakter olabilir!")]
        [Display(Name = "İsim")]
        public string Name { get; set; }

        [Display(Name = "Doğum Tarihi")]
        [Required(ErrorMessage = "Tarih girmek zorunludur!")]
        [Column(TypeName = "date")]
        public DateTime BirthDate { get; set; }

        [Display(Name = "Kütüphane")]
        public int LibraryId { get; set; }

        [Display(Name = "Kütüphane")]
        [ForeignKey("LibraryId")]
        public Library? Library { get; set; }

    }
}
