using TripPlanner.API.Interface;

namespace TripPlanner.API.Database
{
    /// <summary>
    /// Entity framework specific implementation of the generic repository interface
    /// </summary>
    /// <typeparam name="T">Type of entity</typeparam>
    /// <param name="context">Entity framework database context</param>
    public class DatabaseRepository<T>(TripDatabaseContext context) : IRepository<T> where T : class
    {
        /// <summary>
        /// Add entity to database
        /// </summary>
        /// <param name="entity">Entity to add</param>
        public void Add(T entity) => context.Add(entity);

        /// <summary>
        /// Delete entity from database
        /// </summary>
        /// <param name="entity">Entity to delete</param>
        public void Delete(T entity) => context.Remove(entity);

        /// <summary>
        /// Get entity from database
        /// </summary>
        /// <param name="key">Key of entity to return</param>
        /// <returns></returns>
        public T? Get(params object?[]? key) => context.Find<T>(key);

        /// <summary>
        /// Get all entities from database
        /// </summary>
        /// <returns>Collection of entities</returns>
        public IEnumerable<T> GetAll() => context.Set<T>().AsEnumerable();

        /// <summary>
        /// Update entity in database
        /// </summary>
        /// <param name="entity">Entity to update</param>
        public void Update(T entity) => context.Update(entity);
    }
}
