using Gcsb.Connect.CleanArch.Application.Interfaces;
using Gcsb.Connect.CleanArch.Application.UseCases;
using Microsoft.AspNetCore.Mvc;

namespace Gcsb.Connect.CleanArch.WebAPI.UseCases.GetAllCustomers
{

    [Route("api/[controller]")]
    [ApiController]
    public class GetAllCustomersController : ControllerBase
    {
        private readonly IGetAllCustomersUseCase GetAllCustomersUseCase;
        private readonly CustomerPresenter presenter;

        public GetAllCustomersController(IGetAllCustomersUseCase GetAllCustomersUseCase, CustomerPresenter presenter)
        {
            this.GetAllCustomersUseCase = GetAllCustomersUseCase;
            this.presenter = presenter;
        }

        [HttpGet]
        [ProducesResponseType(typeof(GetAllCustomersUseCase), 200)]
        [ProducesResponseType(typeof(ProblemDetails), 400)]
        [Route("GetAllCustomers")]

        public IActionResult GetAllCustomers([FromBody] GetAllCustomersResponse result)
        {
            GetAllCustomersUseCase.Execute(); ;

            return presenter.Result;
        }
    }
}