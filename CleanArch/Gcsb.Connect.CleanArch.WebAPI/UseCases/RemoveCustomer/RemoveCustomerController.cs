using Gcsb.Connect.CleanArch.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Gcsb.Connect.CleanArch.WebAPI.UseCases.RemoveCustomer
{
    [Route("api/[controller]")]
    [ApiController]
    public class RemoveCustomerController : ControllerBase
    {
        private readonly IRemoveCustomerUseCase RemoveCustomerUseCase;
        private readonly CustomerPresenter presenter;

        public RemoveCustomerController(IRemoveCustomerUseCase RemoveCustomerUseCase, CustomerPresenter presenter)
        {
            this.RemoveCustomerUseCase = RemoveCustomerUseCase;
            this.presenter = presenter;
        }

        [HttpDelete]
        [ProducesResponseType(typeof(RemoveCustomerResponse), 200)]
        [ProducesResponseType(typeof(ProblemDetails), 400)]
        [Route("RemoveCustomer")]

        public IActionResult RemoveCustomer ([FromBody] RemoveCustomerResponse result)
        {
            RemoveCustomerUseCase.Execute(result.Id);

            return presenter.Result;
        }
    }
}
