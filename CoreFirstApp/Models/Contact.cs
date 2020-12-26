using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CoreFirstApp.Models
{
	public class Contact
	{
		public int Id { get; set; }
		[Display(Name="Adınız"),Required(ErrorMessage ="Boş Geçemezssiniz")]
		public string Name { get; set; }
		[Display(Name = "Soy Adınız"), Required(ErrorMessage = "Boş Geçemezssiniz")]
		public string Surname { get; set; }
		[Display(Name = "Email "),DataType(DataType.EmailAddress,ErrorMessage ="Lütfen Geçerli Bir Mail Giriniz"), Required(ErrorMessage = "Boş Geçemezssiniz")]
		public string Email { get; set; }
		[Display(Name = "Telefon ")]
		public string Phone { get; set; }
	}
}
