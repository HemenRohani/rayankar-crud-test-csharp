namespace Mc2.CrudTest.Application.Services
{
    public interface ICustomerReadService
    {
        Task<bool> ExistsAsync(string firstname, string lastname, DateOnly dateOfBirth);
    }
}
