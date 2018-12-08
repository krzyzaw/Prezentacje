namespace CommandHandler.Infrastructure.Commands.Forms
{
    public class CreateOrder : ICommand
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        public string ProductId { get; set; }
        public bool Agreement { get; set; }
    }
}