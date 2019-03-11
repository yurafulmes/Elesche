using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Elesche.Models.EquipmentModel
{
    public interface IEquipmentRepository:ICRUD<Equipment>
    {
        IEnumerable<Equipment> Equipments { get; }
        Task SaveAsync();
    }
}
