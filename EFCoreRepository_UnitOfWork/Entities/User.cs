namespace EFCoreRepository_UnitOfWork.Entities
{
    public class User : Entity
    {
        public string Name { get; set; } = null!;

        public string Username { get; set; } = null!;

        public string Email { get; set; } = null!;

        public Address Address { get; set; } = null!;

        private List<Post> _posts = new();
        public ICollection<Post> Posts => _posts;
    }
}