using Microsoft.AspNetCore.Identity;
namespace CRM_mvc.Models.Entities;

public class Chat : IBaseModel
{
    public int Id { get; set; }
    public Customer Customer { get; set; }

    public User User { get; set; }
    public ChatChannel ChatChannel { get; set; }
    public Message Message { get; set; }



    public List<CustomerVerification> CustomerVerifications { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
    public DateTime? DeletedAt { get; set; }
}

public class ChatChannel : IBaseModel
{
    public int Id { get; set; }
    public string Name { get; set; }

    public ICollection<Chat> Chats { get; set; }

    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
    public DateTime? DeletedAt { get; set; }
}

public class Message : IBaseModel
{
    public int Id { get; set; }
    public string Title { get; set; }
    public DateTime ReadDateTime { get; set; }
    public DateTime SendDateTime { get; set; }

    public ICollection<AnswerReturnAction> AnswerReturnActions { get; set; }
    public ICollection<MessageAttachment> MessageAttachments { get; set; }
    public ICollection<Chat> Chats { get; set; }

    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
    public DateTime? DeletedAt { get; set; }
}

public class MessageAttachment : IBaseModel
{
    public int Id { get; set; }
    public string? Title { get; set; }
    public string Path { get; set; }
    public string Type { get; set; }
    public Message Message { get; set; }

    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
    public DateTime? DeletedAt { get; set; }
}