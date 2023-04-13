using System.ComponentModel.DataAnnotations;
namespace CRM_mvc.Models.Entities;

public class Call : IBaseModel
{
    public int Id { get; set; }

    [DataType(DataType.Time)]
    public DateTime Start { get; set; }

    [DataType(DataType.Time)]
    public DateTime End { get; set; }

    public string? Note { get; set; }

    // timestamp
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }

    public Customer Customer { get; set; }
    public User User { get; set; }
    public CallType Type { get; set; }
    public CallChannel Channel { get; set; }
    public ICollection<Answer> Answers { get; set; }
    public DateTime? DeletedAt { get; set; }
}

public class CallType
{
    public int Id { get; set; }
    public string Name { get; set; }


    public ICollection<Call> Calls { get; set; }
}

public class CallChannel
{
    public int Id { get; set; }
    public string Name { get; set; }

    public ICollection<Call> Calls { get; set; }
}
