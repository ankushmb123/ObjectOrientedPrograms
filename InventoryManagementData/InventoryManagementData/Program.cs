using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagementData
{
    class Program
    {
        static void Main(string[] args)
        {

            bool flag = true;
            while (flag)
            {
                Console.WriteLine("\nWelcome to Object Oriented Programs");
                Console.WriteLine("Enter Progran number to get excuted \n1. Inventory management \n2. Extend Inventory data management \n3. Stock account management \n4. Exit");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        InventoryMain Data = new InventoryMain();
                        Data.DisplayData(@"C:\User\@nkush\ObjectOriented _Programs\ObjectOrientedPrograms\InventoryManagementData\InventoryManagementData\json1.json");
                        break;
                    case 2:
                        InventoryMain manage = new InventoryMain();
                        manage.ReadData(@"C:\User\@nkush\ObjectOriented _Programs\ObjectOrientedPrograms\InventoryManagementData\InventoryManagementData\json1.json");
                        manage.DisplayData("Rice");
                        manage.DisplayData("Wheat");
                        manage.DisplayData("Pulses");
                        break;
                    case 3:
                        InventorystockMain Stock = new InventorystockMain();
                        Stock.DisplayData(@"C:\User\@nkush\ObjectOriented _Programs\ObjectOrientedPrograms\InventoryManagementData\InventoryManagementData\json1.json");
                        break;
                    case 4:
                        flag = false;
                        break;
                }
            }
        }
    }
}