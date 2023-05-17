namespace Mc2.CrudTest.Application.Services
{
    public interface ICustomerReadService
    {
        Task<bool> ExistsByEmailAsync(string email);
        Task<bool> ExistsByNameAndBithDateAsync(string firstname, string lastname, DateOnly dateOfBirth);
    }
}
