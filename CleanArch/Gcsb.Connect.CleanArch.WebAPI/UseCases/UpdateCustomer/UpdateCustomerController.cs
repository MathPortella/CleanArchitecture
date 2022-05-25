using Gcsb.Connect.CleanArch.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Gcsb.Connect.CleanArch.WebAPI.UseCases.UpdateCustomer
{
    [Route("api/[controller]")]
    [ApiController]
    public class UpdateCustomerController : ControllerBase
    {
        private readonly IUpdateCustomerUseCase UpdateCustomerUseCase;

        public UpdateCustomerController(IUpdateCustomerUseCase UpdateCustomerUseCase)
        {
            this.UpdateCustomerUseCase = UpdateCustomerUseCase;
        }
        [HttpGet]
        [ProducesResponseType(typeof(UpdateCustomerResponse), 200)]
        [ProducesResponseType(typeof(ProblemDetails), 400)]
        [Route("UpdateCustomer")]
        public IActionResult GetCustomersHistory()
        {
            UpdateCustomerUseCase.Execute(new UpdateCustomerUseCase());

            return presenter.Result;
        }
    }
}