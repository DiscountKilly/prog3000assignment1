using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace prog3000assignment1.Models
{

   
    public class Repository
    {
        public static int reqCount = 0;

        public static List<Request> RequestList = new List<Request>();
        public static List<Request> GetRequests()
        {
            return RequestList;
        }

        public static void InsertRequest(Request request)
        {
            reqCount = reqCount + 1;
            request.RequestID = reqCount;
            RequestList.Add(request);
        }

        public static List<Equipment> GetEquipments()
        {
            return new List<Equipment>
            {
                new Equipment()
                {
                    EquipmentName = "MSI GF63",
                    EquipmentID = 1,
                    EquipmentDesc = "Intel Core i5-9300H, GTX1650, 8GB DDR4, 256GB SSD",
                    EquipmentAvailability = true,
                    EquipmentCat = EquipCategory.Laptop 
                },
                new Equipment()
                {
                    EquipmentName = "Samsung Galaxy TAB A",
                    EquipmentID = 2,
                    EquipmentDesc = "10.1 inches, Quad-Core, 2GB LPDDR4, 32GB",
                    EquipmentAvailability = false,
                    EquipmentCat = EquipCategory.Tablet
                    
                },
                new Equipment()
                {
                    EquipmentName = "Samsung Galaxy S9",
                    EquipmentID = 3,
                    EquipmentDesc = "2.8GHz Quad, 64GB ROM, 4GB RAM",
                    EquipmentAvailability = true,
                    EquipmentCat = EquipCategory.Phone
                    

                },
                new Equipment()
                {
                    EquipmentName = "Corsair Gaming VOID PRO RGB headset",
                    EquipmentID = 4,
                    EquipmentDesc = "Wireless, Carbon, 7.1 Dolby",
                    EquipmentAvailability = false,
                    EquipmentCat = EquipCategory.Another
                }
            };
        }
    }
}
