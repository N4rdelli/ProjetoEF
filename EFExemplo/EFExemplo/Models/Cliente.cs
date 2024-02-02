namespace EFExemplo.Models
{
    public class Cliente
    {
        public Guid ClienteId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public DateOnly Data { get; set; }

    }
}
