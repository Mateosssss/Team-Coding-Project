using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace ProjektZespołówka.Services.Interfaces
{
    /// <summary>
    /// Generic service interface for CRUD operations
    /// </summary>
    /// <typeparam name="TEntity">The entity type</typeparam>
    /// <typeparam name="TDto">The DTO type for read operations</typeparam>
    /// <typeparam name="TCreateUpdateDto">The DTO type for create/update operations</typeparam>
    public interface IGenericService<TEntity, TDto, TCreateUpdateDto>
        where TEntity : class
    {
        /// <summary>
        /// Get entity by ID
        /// </summary>
        Task<TDto?> GetByIdAsync(Guid id);

        /// <summary>
        /// Get all entities
        /// </summary>
        Task<IEnumerable<TDto>> GetAllAsync();

        /// <summary>
        /// Get entities matching the filter
        /// </summary>
        Task<IEnumerable<TDto>> FindAsync(Expression<Func<TEntity, bool>> predicate);

        /// <summary>
        /// Create a new entity
        /// </summary>
        Task<TDto> CreateAsync(TCreateUpdateDto dto);

        /// <summary>
        /// Update an existing entity
        /// </summary>
        Task<TDto> UpdateAsync(Guid id, TCreateUpdateDto dto);

        /// <summary>
        /// Delete an entity
        /// </summary>
        Task DeleteAsync(Guid id);

        /// <summary>
        /// Check if entity exists
        /// </summary>
        Task<bool> ExistsAsync(Guid id);
    }
}
