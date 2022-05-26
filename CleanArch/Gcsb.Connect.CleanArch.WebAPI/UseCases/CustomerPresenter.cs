using Gcsb.Connect.CleanArch.Application.Boundaries;
using Gcsb.Connect.CleanArch.Domain.Entities;
using Gcsb.Connect.CleanArch.WebAPI.UseCases.GetAllCustomers;
using Gcsb.Connect.CleanArch.WebAPI.UseCases.GetCustomerById;
using Microsoft.AspNetCore.Mvc;

namespace Gcsb.Connect.CleanArch.WebAPI.UseCases
{
    public class CustomerPresenter : IOutput<Customer>, IOutput<List<Customer>>, IOutput<string>
    {
        public IActionResult Result { get; private set; }

        public void Error(string message)
        {
            var problemDetails = new ProblemDetails
            {
                Title = "An error occurred",
                Detail = message
            };

            Result = new BadRequestObjectResult(problemDetails);
        }

        public void NotFound(string message)
        {
            var problemDetails = new ProblemDetails
            {
                Title = "An error occurred",
                Detail = message
            };

            Result = new NotFoundObjectResult(problemDetails);
        }

        public void Standard(string result)
        {
            Result = new OkObjectResult(result);
        }
        public void Standard(Customer result)
        {
            var response = new GetCustomerByIdResponse(result.Id, result.Name, result.BirthDate, result.Rg, result.Cpf, result.Address, result.RegistrationDate, result.ClientActive);
            Result = new OkObjectResult(response);
        }
        public void Standard(List<Customer> result)
        {
            var response = new List<GetAllCustomersResponse>();
            result.ForEach(r => response.Add(new GetAllCustomersResponse(r.Id, r.Name, r.BirthDate, r.Rg, r.Cpf, r.Address, r.RegistrationDate, r.ClientActive)));
            Result = new OkObjectResult(response);
        }
    }
}
