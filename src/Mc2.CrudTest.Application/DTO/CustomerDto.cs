namespace Mc2.CrudTest.Application.DTO;

public class CustomerDto
{
    public Guid Id { get; set; }
    public string Firstname { get; set; }
    public string Lastname { get; set; }
    public DateOnly DateOfBirth { get; set; }
    string PhoneNumber { get; set; }
    string Email { get; set; }
    string BankAccountNumber { get; set; }


}
