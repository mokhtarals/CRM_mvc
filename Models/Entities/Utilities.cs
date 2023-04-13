using System;
using Microsoft.AspNetCore.Identity;

namespace CRM_mvc.Models.Entities;

public class Extention : IBaseModel
{
    public int Id { get; set; }

    public int ExtentionNumber { get; set; }

    public ICollection<User> Users { get; set; }

    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
    public DateTime? DeletedAt { get; set; }
}