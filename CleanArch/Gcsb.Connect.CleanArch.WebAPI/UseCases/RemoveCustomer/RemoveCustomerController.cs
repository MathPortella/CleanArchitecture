using Gcsb.Connect.CleanArch.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Gcsb.Connect.CleanArch.WebAPI.UseCases.RemoveCustomer
{
    [Route("api/[controller]")]
    [ApiController]
    public class RemoveCustomerController : ControllerBase
    {
        private readonly IRemoveCustomerUseCase RemoveCustomerUseCase;

        public RemoveCustomerController(IRemoveCustomerUseCase RemoveCustomerUseCase)
        {
            this.RemoveCustomerUseCase = RemoveCustomerUseCase;
        }
        [HttpGet]
        [ProducesResponseType(typeof(RemoveCustomerResponse), 200)]
        [ProducesResponseType(typeof(ProblemDetails), 400)]
        [Route("RemoveCustomer")]
    }
}
