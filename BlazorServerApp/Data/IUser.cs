namespace BlazorServerApp.Data
{
    public interface IUser
    {
        int Age { get; set; }
        string? Country { get; set; }
        string Email { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }
        string? Phone { get; set; }
        string Username { get; set; }
    }
}