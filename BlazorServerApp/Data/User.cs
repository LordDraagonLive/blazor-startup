namespace BlazorServerApp.Data
{
    public class User : IUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Username { get; set; }
        public int Age { get; set; }
        public string? Country { get; set; } = null;
        public string? Phone { get; set; }

        public User()
        {

        }

    }
}
