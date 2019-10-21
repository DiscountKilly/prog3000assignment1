using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace prog3000assignment1.Models
{
    public class Repository
    {
        List<Request> Requests = new List<Request>();


        List<Equipment> Equipment = new List<Equipment>()
        {
            new Equipment()
            {
                EquipmentName = "MSI GF63",
                EquipmentID = 1,
                EquipmentDesc = "Intel Core i5-9300H, GTX1650, 8GB DDR4, 256GB SSD",
                EquipmentAvailability = true
            },
            new Equipment()
            {
                EquipmentName = "Samsung Galaxy TAB A",
                EquipmentID = 2,
                EquipmentDesc = "10.1 inches, Quad-Core, 2GB LPDDR4, 32GB",
                EquipmentAvailability = false
            },
            new Equipment()
            {
                EquipmentName = "Samsung Galaxy S9",
                EquipmentID = 3,
                EquipmentDesc = "2.8GHz Quad, 64GB ROM, 4GB RAM",
                EquipmentAvailability = true
               
            },
            new Equipment()
            {
                EquipmentName = "Corsair Gaming VOID PRO RGB headset",
                EquipmentID = 4,
                EquipmentDesc = "Wireless, Carbon, 7.1 Dolby",
                EquipmentAvailability = false
            }
        };
    }
}
