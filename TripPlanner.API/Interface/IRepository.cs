namespace TripPlanner.API.Interface
{
    /// <summary>
    /// Provides access to CRUD operations for a domain entity
    /// </summary>
    /// <typeparam name="T">Type of entity</typeparam>
    public interface IRepository<T> where T : class
    {
        /// <summary>
        /// Get entity
        /// </summary>
        /// <param name="id">Id of entity to get</param>
        /// <returns></returns>
        T? Get(params object?[]? key);

        /// <summary>
        /// Get all entities
        /// </summary>
        /// <returns>Collection of entities</returns>
        IEnumerable<T> GetAll();

        /// <summary>
        /// Add entity
        /// </summary>
        /// <param name="entity">Entity to add</param>
        void Add(T entity);

        /// <summary>
        /// Update entity
        /// </summary>
        /// <param name="entity">Entity to update</param>
        void Update(T entity);

        /// <summary>
        /// Delete entity
        /// </summary>
        /// <param name="entity">Entity to delete</param>
        void Delete(T entity);

        /// <summary>
        /// Delete entity by id
        /// </summary>
        /// <param name="id">Id of entity to delete</param>
        void Delete(int id)
        {
            var entity = Get(id);
            if (entity is not null)
                Delete(entity);
        }
    }
}
