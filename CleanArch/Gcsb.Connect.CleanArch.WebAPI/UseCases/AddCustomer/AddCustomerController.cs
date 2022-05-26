using Gcsb.Connect.CleanArch.Application.Interfaces;
using Gcsb.Connect.CleanArch.Application.UseCases;
using Gcsb.Connect.CleanArch.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace Gcsb.Connect.CleanArch.WebAPI.UseCases.AddCustomer
{
    [Route("api/[controller]")]
    [ApiController]
    public class AddCustomerController : ControllerBase
    {
        private readonly IAddCustomerUseCase AddCustomerUseCase;
        private readonly CustomerPresenter presenter;
        
        public AddCustomerController(IAddCustomerUseCase AddCustomerUseCase, CustomerPresenter presenter)
        {
            this.AddCustomerUseCase = AddCustomerUseCase;
            this.presenter = presenter;
        }

        [HttpPost]
        [ProducesResponseType(typeof(AddCustomerResponse), 200)]
        [ProducesResponseType(typeof(ProblemDetails), 400)]
        [Route("AddCustomer")]
        public IActionResult AddCustomer([FromBody] AddCustomerRequest input)
        {
            AddCustomerUseCase.Execute(new Customer(input.Name, input.BirthDate, input.Rg, input.Cpf, input.Address));
            return presenter.Result;
        }
    }
}