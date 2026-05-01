using System.ComponentModel.DataAnnotations;

namespace PlatformService.Models
{
	public class Platform
	{
		[Key]
		public int Id { get; set; }

		[Required]
		[StringLength(100)]
		public string? Name { get; set; }

		[Required]
		[StringLength(100)]
		public string? Publisher { get; set; }

		[Required]
		[StringLength(50)]
		public string? Cost { get; set; }
	}
}