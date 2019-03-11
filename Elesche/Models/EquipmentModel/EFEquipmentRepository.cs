using Elesche.Models.SchoolModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Elesche.Models.EquipmentModel
{
    public class EFEquipmentRepository : IEquipmentRepository
    {        /// <summary>
             /// Object of database context
             /// </summary>
        private ApplicationDbContext context;

        public EFEquipmentRepository(ApplicationDbContext context)
        {
            this.context = context;

        }
        public IEnumerable<Equipment> Equipments => context.Equipments;

        public  void Add(Equipment equipment)
        {
            context.Equipments.Add(equipment);
        }

        void ICRUD<Equipment>.Delete(Equipment element)
        {
            throw new NotImplementedException();
        }

        Task<Equipment> ICRUD<Equipment>.FindAsync(int? ID)
        {
            throw new NotImplementedException();
        }

        async Task IEquipmentRepository.SaveAsync()
        {
            await context.SaveChangesAsync();
        }

        void ICRUD<Equipment>.Update(Equipment element)
        {
            throw new NotImplementedException();
        }
    }
}
