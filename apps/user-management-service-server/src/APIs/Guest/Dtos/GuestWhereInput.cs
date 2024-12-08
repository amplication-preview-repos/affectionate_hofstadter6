namespace UserManagementService.APIs.Dtos;

public class GuestWhereInput
{
    public string? Address { get; set; }

    public DateTime? BirthDate { get; set; }

    public DateTime? CreatedAt { get; set; }

    public string? Email { get; set; }

    public string? FullName { get; set; }

    public string? Id { get; set; }

    public string? PassportSeries { get; set; }

    public string? PhoneNumber { get; set; }

    public DateTime? UpdatedAt { get; set; }
}
