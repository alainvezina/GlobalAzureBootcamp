using System.ComponentModel.DataAnnotations;

namespace Step1WebApp.Models
{
	public class QueueMessageModel
	{
		[Required]
		public string Text { get; set; }
	}
}