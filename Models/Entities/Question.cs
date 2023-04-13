namespace CRM_mvc.Models.Entities;

public class Question : IBaseModel
{
    public int Id { get; set; }
    public string Title { get; set; }
    public ICollection<Answer> Answers { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
    public DateTime? DeletedAt { get; set; }
}

public class Answer : IBaseModel
{
    public int Id { get; set; }
    public string Title { get; set; }

    public int QuestionId { get; set; }
    public Question Question { get; set; }

    public ICollection<Call> Calls { get; set; }

    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
    public DateTime? DeletedAt { get; set; }
}

public class ReturnAction
{
    public int Id { get; set; }
    public string Title { get; set; }
    public ICollection<AnswerReturnAction> AnswerReturnActions { get; set; }

    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
}

public class AnswerReturnAction : IBaseModel
{
    public int Id { get; set; }
    public bool IsDone { get; set; }
    public DateTime DateTime { get; set; }

    public Message Message { get; set; }
    public Answer Answer { get; set; }
    public ReturnAction ReturnAction { get; set; }


    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
    public DateTime? DeletedAt { get; set; }
}