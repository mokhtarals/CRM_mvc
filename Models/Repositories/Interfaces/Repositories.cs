using CRM_mvc.Models.Entities;
using CRM_mvc.Utilities.Enumerations;

namespace CRM_mvc.Models.Repositories.Interfaces
{
    public interface ICallRepository
    {
        IEnumerable<Call> GetCalls();
        Call? GetCallByID(int callID);
        Call InsertCall(Call call);
        DbStatus DeleteCall(int callID);
        DbStatus RestoreCall(int callID);
        DbStatus UpdateCall(Call call);
        IQueryable<Call> WithTrashed();
        DbStatus Save();
    }

    // Chat
    public interface IChatRepository
    {
        IEnumerable<Chat> GetChats();
        Chat GetChatByID(int chatID);
        void InsertChat(Chat chat);
        void DeleteChat(int chatID);
        void UpdateChat(Chat chat);
        void Save();
    }

    // Customer
    public interface ICustomerRepository
    {
        IEnumerable<Customer> GetCustomers();
        Customer GetCustomerByID(int customerID);
        void InsertCustomer(Customer customer);
        void DeleteCustomer(int customerID);
        void UpdateCustomer(Customer customer);
        void Save();
    }

    // Question
    public interface IQuestionRepository
    {
        IEnumerable<Question> GetQuestions();
        Question GetQuestionByID(int questionID);
        void InsertQuestion(Question question);
        void DeleteQuestion(int questionID);
        void UpdateQuestion(Question question);
        void Save();
    }

    // Answer
    public interface IAnswerRepository
    {
        IEnumerable<Answer> GetAnswers();
        Answer GetAnswerByID(int answerID);
        void InsertAnswer(Answer answer);
        void DeleteAnswer(int answerID);
        void UpdateAnswer(Answer answer);
        void Save();
    }

    // Message
    public interface IMessageRepository
    {
        IEnumerable<Message> GetMessages();
        Message GetMessageByID(int messageID);
        void InsertMessage(Message message);
        void DeleteMessage(int messageID);
        void UpdateMessage(Message message);
        void Save();
    }
}