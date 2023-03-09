using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Components;

namespace LibraryMVC.Models
{
	public class Book
	{

		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.None)]
		[Column(TypeName = "nchar(13)")]
		[Required(ErrorMessage = "ISBN girmek zorunludur!")]
		[StringLength(13, MinimumLength = 13, ErrorMessage = "13 karakter olabilir!")]
		public string ISBN { get; set; }

		[Column(TypeName = "nchar(1500)")]
		[Required(ErrorMessage = "İsim girmek zorunludur!")]
		[StringLength(1500, ErrorMessage = "En fazla 1500 karakter olabilir!")]
		[Display(Name = "Adı")]
		public string Title { get; set; }

		[Display(Name = "Yazar")]
		[Required(ErrorMessage = "Yazar adı girmek zorunludur!")]
		public long AuthorId { get; set; }

		[ForeignKey("AuthorId")]
		[Display(Name = "Yazar")]
		public Author? Author { get; set; }

	}
}
