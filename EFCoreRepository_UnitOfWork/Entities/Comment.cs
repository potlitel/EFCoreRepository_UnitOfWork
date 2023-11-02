namespace EFCoreRepository_UnitOfWork.Entities
{
    public class Comment : Entity
    {
        public int PostId { get; set; }
        public string Name { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string Body { get; set; } = null!;
    }
}