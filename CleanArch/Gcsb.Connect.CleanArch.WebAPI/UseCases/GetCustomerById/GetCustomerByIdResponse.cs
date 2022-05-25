namespace Gcsb.Connect.CleanArch.WebAPI.UseCases.GetCustomerById
{
    public class GetCustomerByIdResponse
    {
        public Guid Id { get; private set; }
        public string Name { get; private set; }
        public string BirthDate { get; private set; }
        public int Rg { get; private set; }
        public int Cpf { get; private set; }
        public string Address { get; private set; }
        public DateTime RegistrationDate { get; private set; }
        public bool ClientActive { get; private set; }

        public GetCustomerByIdResponse(Guid id, string name, string birthDate, int rg, int cpf, string address, DateTime registrationDate, bool clientActive)
        {
            Id = id;
            Name = name;
            BirthDate = birthDate;
            Rg = rg;
            Cpf = cpf;
            Address = address;
            RegistrationDate = registrationDate;
            ClientActive = clientActive;
        }
    }
}
