using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Elesche.Models
{
    public interface ICRUD<T>
    {
        /// <summary>
        /// System CRUD-Create
        /// </summary>
        /// <param name="element">The element that will be added</param>
        void Add(T element);
        /// <summary>
        /// System CRUD-Update
        /// </summary>
        /// <param name="element">The element that will be changed</param>
        void Update(T element);
        /// <summary>
        /// System CRUD-Delete
        /// </summary>
        /// <param name="element">The element that will be deleted</param>
        void Delete(T element);
        Task<T> FindAsync(int? ID);

    }
}
