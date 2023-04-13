using Microsoft.AspNetCore.Identity;

namespace CRM_mvc.Models.Entities;

public class User : IdentityUser
{
    public string Name { get; set; }
    public ICollection<Extention> Extentions { get; set; }
    public ICollection<Call> Calls { get; set; }
}