namespace Quiz_5070_Kunakorn.Models;

public class UserViewModel
{
    public string? UserId { get; set; }
    public string? password { get; set; }

    public List<UserViewModel> Users { get; set; } = new();
}