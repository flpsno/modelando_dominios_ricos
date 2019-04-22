using PaymentContext.Domain.Entities;

namespace PaymentContext.Domain.Repositories
{
    public interface IStudentRepository
    {
        bool DocumentExists();
        bool EmailExists();
        void CreateSubscription(Student student);
    }
}