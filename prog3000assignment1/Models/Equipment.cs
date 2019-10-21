using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace prog3000assignment1.Models
{
    public class Equipment
    {
        public string EquipmentName { get; set; }
        public int EquipmentID { get; set; }
        public string EquipmentDesc { get; set; }
        public bool EquipmentAvailability { get; set; }
        public EquipCategory EquipmentCat { get; set; }
    }
}
