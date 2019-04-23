using PaymentContext.Shared.Commands;

namespace PaymentContext.Domain.Command
{
    public class CommandResult : ICommandResult
    {
        public CommandResult()
        {
            
        }
        public CommandResult(bool success, string message)
        {
            Success = success;
            Message = message;
        }

        public bool Success { get; set; }  
        public string Message { get; set; }
    }   
}