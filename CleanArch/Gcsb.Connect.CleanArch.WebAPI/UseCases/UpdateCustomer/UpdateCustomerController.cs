using Gcsb.Connect.CleanArch.Application.Interfaces;
using Gcsb.Connect.CleanArch.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace Gcsb.Connect.CleanArch.WebAPI.UseCases.UpdateCustomer
{
    [Route("api/[controller]")]
    [ApiController]
    public class UpdateCustomerController : ControllerBase
    {
        private readonly IUpdateCustomerUseCase UpdateCustomerUseCase;
        private readonly CustomerPresenter presenter;

        public UpdateCustomerController(IUpdateCustomerUseCase UpdateCustomerUseCase, CustomerPresenter presenter)
        {
            this.UpdateCustomerUseCase = UpdateCustomerUseCase;
            this.presenter = presenter;
        }

        [HttpPut]
        [ProducesResponseType(typeof(UpdateCustomerResponse), 200)]
        [ProducesResponseType(typeof(ProblemDetails), 400)]
        [Route("UpdateCustomer")]
        public IActionResult UpdateCustomer([FromBody]UpdateCustomerRequest input)
        {
            UpdateCustomerUseCase.Execute(new Customer(input.Id, input.Name, input.BirthDate, input.Rg, input.Cpf, input.Address));
            return presenter.Result;
        }
    }
}