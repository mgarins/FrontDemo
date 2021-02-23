using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FrontWebApp.Models
{
	public class AccountViewModel
	{
		// Name, Email, Phone Number, Amount Due and Payment Due Date
		public int Id { get; set; }
		public string Name { get; set; }
		public string LastName { get; set; }
		public string FirstName { get; set; }
		public string Email { get; set; }
		[Editable(false)]
		[Display(Name = "Phone Number")]
		[DisplayFormat(DataFormatString = "{0:(###)-###-####}")]
		public Int64 PhoneNumber { get; set; }

		[Editable(false)]
		[Display(Name = "Amount Due")]
		[DisplayFormat(DataFormatString = "${0:N2}")]
		public decimal AmountDue { get; set; }

		[Editable(false)]
		[Display(Name = "Payment Due Date")]
		[DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}")]
		public DateTime? PaymentDueDate { get; set; }
		[Editable(false)]
		[Display(Name = "Account Status")]
		public AccountStatuses AccountStatusId { get; set; }

	}
}
