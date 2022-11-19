﻿using OOPS_PROBLEMS.InventoryManagement;
using OOPS_PROBLEMS.InventoryManagementSystem;

namespace OOPS_PROBLEMS
{

    internal class Program
    {
        const string INVENTORY_DATA_FILE_PATH = @"C:\GetRepositry\11_12_Day-ObjectOrientedPrograming\OOPS_PROBLEMS\InventoryManagement\Inventory.json";
        const string INVENTORY_MANAGEMENT_DATA_FILE_PATH = @"C:\GetRepositry\11_12_Day-ObjectOrientedPrograming\OOPS_PROBLEMS\InventoryManagementSystem\InventoryDetails.json";
        static void Main(string[] args)
        {
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("1.Display Inventory\n");
                Console.WriteLine("Please Enter Your Choice");
                Console.WriteLine("---------------------------------------------------");
                int option = Convert.ToInt32(Console.ReadLine());

                switch (option)
                {
                    case 1:
                        Console.WriteLine("----------------- Display Inventory --------------------\n");
                        Inventory inventory = new Inventory();
                        inventory.ReadJsonFile(INVENTORY_DATA_FILE_PATH);
                        Console.WriteLine("------------------------------------------------");
                        break;

                    case 2:
                        bool flag1 = true;
                        while (flag1)
                        {
                            Console.WriteLine("1.Add List\n2.Delete List\n3.Edit List");
                            Console.WriteLine("Please Enter Your Choice");
                            Console.WriteLine("---------------------------------------------------");
                            int option1 = Convert.ToInt32(Console.ReadLine());

                            switch (option1)
                            {
                                case 1:
                                    InventoryFactory factory = new InventoryFactory();
                                    factory.ReadJsonFile(INVENTORY_MANAGEMENT_DATA_FILE_PATH);
                                    InventoryDetails detail = new InventoryDetails()
                                    {
                                        Name = "Masura",
                                        Weight = 13,
                                        Price = 240
                                    };
                                    factory.AddInventory("RiceList", detail);
                                    factory.WriteToJson(INVENTORY_MANAGEMENT_DATA_FILE_PATH);
                                    Console.WriteLine("----------------------------------------------");
                                    break;

                                case 2:
                                    InventoryFactory factory1 = new InventoryFactory();
                                    factory1.ReadJsonFile(INVENTORY_MANAGEMENT_DATA_FILE_PATH);
                                    InventoryDetails detail1 = new InventoryDetails()
                                    {
                                        Name = "Spelt",
                                        Weight = 25,
                                        Price = 200
                                    };
                                    factory1.DeleteInventory("WheatList", "Spelt");
                                    factory1.WriteToJson(INVENTORY_MANAGEMENT_DATA_FILE_PATH);
                                    Console.WriteLine("----------------------------------------------");
                                    break;

                                case 3:
                                    InventoryFactory factory2 = new InventoryFactory();
                                    factory2.ReadJsonFile(INVENTORY_MANAGEMENT_DATA_FILE_PATH);
                                    factory2.EditInventory("PulsesList", "Pigeon");
                                    factory2.WriteToJson(INVENTORY_MANAGEMENT_DATA_FILE_PATH);
                                    Console.WriteLine("----------------------------------------------");
                                    break;

                                default:
                                    Console.WriteLine("Invalid Choice");
                                    break;
                            }
                        }
                        break;

                    default:
                        Console.WriteLine("Invalid Choice");
                        Console.ReadKey();
                        break;
                }
            }
        }
    }
}