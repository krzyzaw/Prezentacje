namespace CommandHandler.Infrastructure.Commands.Forms
{
    public class CreateContactRequest : ICommand
    {
        public string Email { get; set; }
        public string ProblemDescription { get; set; }
    }
}