namespace CommandHandler.Infrastructure.Commands.Leads
{
    public class CreateLead : ICommand
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        public bool Agreement { get; set; }
    }
}