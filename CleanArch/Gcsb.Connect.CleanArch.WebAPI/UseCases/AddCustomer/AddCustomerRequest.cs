using System.ComponentModel.DataAnnotations;

namespace Gcsb.Connect.CleanArch.WebAPI.UseCases.AddCustomer
{
    public class AddCustomerRequest 
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public string BirthDate { get; set; }
        [Required]
        public int Rg { get; set; }
        [Required]
        public int Cpf { get; set; }
        [Required]
        public string Address { get; set; }
    }
}
