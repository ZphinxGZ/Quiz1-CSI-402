namespace Quiz_5070_Kunakorn.Models;

public class UserViewModel
{
    public string? UserId { get; set; }
    public string? password { get; set; }

    public List<UserViewModel> Users { get; set; } = new();
}

public class ScoreViewModel
{
    public List<int> Scores { get; set; } = new();
    public int TotalScore { get; set; }
    public string? Grade { get; set; }
}

public class StudentDetailsViewModel
{
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public string? StudentId { get; set; }
    public int Age { get; set; }
    public string? Email { get; set; }
    public string? PhoneNumber { get; set; }
    public string? Department { get; set; }
    public string? Address { get; set; }
}