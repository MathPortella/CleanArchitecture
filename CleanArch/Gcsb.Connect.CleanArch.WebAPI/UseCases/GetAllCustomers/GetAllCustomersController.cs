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

        public GetAllCustomersController(IGetAllCustomersUseCase GetAllCustomersUseCase)
        {
            this.GetAllCustomersUseCase = GetAllCustomersUseCase;
        }
        [HttpGet]
        [ProducesResponseType(typeof(GetAllCustomersUseCase), 200)]
        [ProducesResponseType(typeof(ProblemDetails), 400)]
        [Route("GetAllCustomers")]
    }
}