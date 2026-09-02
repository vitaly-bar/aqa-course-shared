namespace ApiTest.DTO.BookStore;

public class LoginUserResponseDTO
{
    public string UserId { get; set; }
    public string Username { get; set; }
    public string Password { get; set; }
    public string Token { get; set; }
    public string Expires { get; set; }
    public DateTime Created_Date { get; set; }
    public bool IsActive { get; set; }
}