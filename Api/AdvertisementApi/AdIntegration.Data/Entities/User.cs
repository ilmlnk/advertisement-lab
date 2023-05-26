using Microsoft.AspNetCore.Identity;

namespace AdIntegration.Data.Entities;

public abstract class User : IdentityUser
{
    public int UserId { get; set; }
    public string FirstName { get; set; }
    public string? LastName { get; set; }
    public override string UserName { get; set; }
    public string Password { get; set; }
}
