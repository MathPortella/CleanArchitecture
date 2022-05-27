using Gcsb.Connect.CleanArch.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Gcsb.Connect.CleanArch.WebAPI.UseCases.GetCustomerById
{

    [Route("api/[controller]")]
    [ApiController]
    public class GetCustomerByIdController : ControllerBase
    {
        private readonly IGetCustomerByIdUseCase GetCustomerByIdUseCase;
        private readonly CustomerPresenter presenter;

        public GetCustomerByIdController(IGetCustomerByIdUseCase GetCustomerByIdUseCase, CustomerPresenter presenter)
        {
            this.GetCustomerByIdUseCase = GetCustomerByIdUseCase;
            this.presenter = presenter;
        }

        [HttpGet]
        [ProducesResponseType(typeof(GetCustomerByIdResponse), 200)]
        [ProducesResponseType(typeof(ProblemDetails), 400)]
        [Route("GetCustomerById")]

        public IActionResult GetCustomerById([FromBody] GetCustomerByIdResponse result)
        {
            GetCustomerByIdUseCase.Execute(result.Id);

            return presenter.Result;
        }
    }
}
