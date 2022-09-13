using ObjectOrientedPrograms.InventoryManagement;
using ObjectOrientedPrograms.InventoryManagementSystem;
using ObjectOrientedPrograms.StockManagement;
using ObjectOrientedPrograms.StockManagementSystem;

namespace ObjectOrientedPrograms
{
    internal class Program
    {
        //given inventory path to json
        const string INVENTORY_DATA_FILE_PATH = @"C:\Users\Suraj Sinha\OneDrive\Desktop\Bridgelabz\ObjectOrientedProgram\ObjectOrientedPrograms\InventoryManagement\Inventory.json";
        const string INVENTORYDETAILS_DATA_FILE_PATH = @"C:\Users\Suraj Sinha\OneDrive\Desktop\Bridgelabz\ObjectOrientedProgram\ObjectOrientedPrograms\InventoryManagementSystem\InventoryDetails.json";
        const string STOCK1_DATA_FILE_PATH = @"C:\Users\Suraj Sinha\OneDrive\Desktop\Bridgelabz\ObjectOrientedProgram\ObjectOrientedPrograms\StockManagement\Stock1.json";
        const string STOCK_DATA_FILE_PATH = @"C:\Users\Suraj Sinha\OneDrive\Desktop\Bridgelabz\ObjectOrientedProgram\ObjectOrientedPrograms\StockManagementSystem\Stock.json";
        const string COMPANY_DATA_FILE_PATH = @"C:\Users\Suraj Sinha\OneDrive\Desktop\Bridgelabz\ObjectOrientedProgram\ObjectOrientedPrograms\StockManagementSystem\Company.json";
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Select Programs\n 1.InventoryManagement\n 2.InventoryManagementSystem\n 3.StockManagement\n 4.StockManagementSystem");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        Inventory inventory = new Inventory();
                        inventory.ReadJsonFile(INVENTORY_DATA_FILE_PATH);
                        break;
                    case 2:
                        InventoryFactory inventoryFactory = new InventoryFactory();
                        inventoryFactory.ReadJsonFile(INVENTORYDETAILS_DATA_FILE_PATH);
                        InventoryDetails details = new InventoryDetails()
                        {
                            Name = "Basmati",
                            weight = 10,
                            price = 20,
                        };
                        //Add Inventory
                        inventoryFactory.AddInventory("RiceList", details);
                        inventoryFactory.WriteToJson(INVENTORYDETAILS_DATA_FILE_PATH);
                        //Delete Inventory
                        inventoryFactory.DeleteInventory("RiceList", "Basmati");
                        inventoryFactory.WriteToJson(INVENTORYDETAILS_DATA_FILE_PATH); 
                        //Edit Inventory
                        inventoryFactory.EditInventory("RiceList", "Basmati");
                        inventoryFactory.WriteToJson(INVENTORYDETAILS_DATA_FILE_PATH);
                        break;
                    case 3:
                        Stock1 stock = new Stock1();
                        stock.ReadJsonFile(STOCK1_DATA_FILE_PATH);
                        break;
                    case 4:
                        StockManage stockmanagement = new StockManage();
                        stockmanagement.ReadJsonFileStock(STOCK_DATA_FILE_PATH);
                        stockmanagement.ReadJsonFileCompany(COMPANY_DATA_FILE_PATH);
                        //Company company = new Company()
                        Stock stock2 = new Stock()
                        {
                            Name = "Facebook",
                            NoOfShares = 10,
                            PricePerShare = 250,
                        };
                        stockmanagement.SellStockShares(stock2);
                        stockmanagement.WriteToJsonStock(STOCK_DATA_FILE_PATH);
                        stockmanagement.WriteToJsoncompany(COMPANY_DATA_FILE_PATH);
                        //stockmanagement.BuyCompanyShares(Company);
                        //stockmanagement.ReadJsonFileStock(STOCK_DATA_FILE_PATH);
                        //stockmanagement.ReadJsonFileCompany(COMPANY_DATA_FILE_PATH);
                        break;

                }
            }
        }
    }
}
    
