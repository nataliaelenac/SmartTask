namespace SmartTask.Models
{
    public class User
    {
        public int Id { get; set; }             // ID intern
        public string Email { get; set; }       // Email de login
        public string Username { get; set; }    // Numele afișat
        public string Password { get; set; }    // Parola (va fi hash-uită mai târziu)
    }
}
