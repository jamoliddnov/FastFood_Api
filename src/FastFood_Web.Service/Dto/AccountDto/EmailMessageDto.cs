using System.ComponentModel.DataAnnotations;

namespace FastFood_Web.Service.Dto.AccountDto
{
    public class EmailMessageDto
    {
        [Required]
        public string To { get; set; } = String.Empty;
        [Required]
        public string Body { get; set; } = String.Empty;
        [Required]
        public string Subject { get; set; } = String.Empty;
    }
}
