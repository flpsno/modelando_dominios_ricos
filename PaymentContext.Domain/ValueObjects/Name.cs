using Flunt.Validations;
using PaymentContext.Shared.ValueObjects;

namespace PaymentContext.Domain.ValueObjects
{
    public class Name : ValueObject
    {
        public Name(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;

            AddNotifications(new Contract()
                .Requires()
                .HasMinLen(FirstName, 3, "Name.FirstName", "Nome deve conter pelo menos 3 caracteres")
                .HasMinLen(LastName, 3, "Name.LastName", "Sobrenome deve conter pelo menos 3 caracteres")
                .HasMaxLen(FirstName, 3, "Name.FirstName", "Nome deve conter até 40 caracteres")
            );

            if (string.IsNullOrEmpty(FirstName)) 
                AddNotification("Name.FirstName", "Nome Inválido"); 

            if (string.IsNullOrEmpty(LastName)) 
                AddNotification("Name.LastName", "Sobrenome Inválido");                 
        }

        public string FirstName { get;  private set; }
        public string LastName { get; private set; }

        public override string ToString()
        {
            return $"{ FirstName } { LastName}";
        }
    }
}