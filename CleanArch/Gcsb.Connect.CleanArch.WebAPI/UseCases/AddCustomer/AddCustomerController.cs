using Gcsb.Connect.CleanArch.Application.Interfaces;
using Gcsb.Connect.CleanArch.Application.UseCases;
using Microsoft.AspNetCore.Mvc;

namespace Gcsb.Connect.CleanArch.WebAPI.UseCases.AddCustomer
{
    [Route("api/[controller]")]
    [ApiController]
    public class AddCustomerController : ControllerBase
    {
        private readonly IAddCustomerUseCase AddCustomerUseCase;
        
        public AddCustomerController(IAddCustomerUseCase AddCustomerUseCase)
        {
            this.AddCustomerUseCase = AddCustomerUseCase;
        }
        [HttpGet]
        [ProducesResponseType(typeof(AddCustomerResponse), 200)]
        [ProducesResponseType(typeof(ProblemDetails), 400)]
        [Route("AddCustomer")]
        public IActionResult AddCustomer([FromBody] AddCustomerRequest input)
        {
            AddCustomerUseCase.Execute(new CustomersUcRequest(input.Name, input.BirthDate, input.Rg, input.Cpf, input.Address));
        }
    }
}