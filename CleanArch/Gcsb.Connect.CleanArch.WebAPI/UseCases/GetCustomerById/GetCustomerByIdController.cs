using Gcsb.Connect.CleanArch.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Gcsb.Connect.CleanArch.WebAPI.UseCases.GetCustomerById
{

    [Route("api/[controller]")]
    [ApiController]
    public class GetCustomerByIdController : ControllerBase
    {
        private readonly IGetCustomerByIdUseCase GetCustomerByIdUseCase;

        public GetCustomerByIdController(IGetCustomerByIdUseCase GetCustomerByIdUseCase)
        {
            this.GetCustomerByIdUseCase = GetCustomerByIdUseCase;
        }
        [HttpGet]
        [ProducesResponseType(typeof(GetCustomerByIdResponse), 200)]
        [ProducesResponseType(typeof(ProblemDetails), 400)]
        [Route("GetCustomerById")]
    }
}
