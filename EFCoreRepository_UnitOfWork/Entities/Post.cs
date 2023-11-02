namespace EFCoreRepository_UnitOfWork.Entities
{
    public class Post : Entity
    {
        public int UserId { get; set; }
        public string Title { get; set; } = null!;
        public string Body { get; set; } = null!;

        private List<Comment> _comments = new();
        public ICollection<Comment> Comments => _comments;
    }
}