namespace EFCoreRepository_UnitOfWork.Interfaces
{
    public interface ICustomPostRepository : IRepository<Post>, IReadRepository<Post>
    {
        new Post Add(Post entity);

        Task<Post?> GetPostWithCommentsAsync(int id);

        IEnumerable<Post> GetPostWithMoreComments(int count);
    }
}