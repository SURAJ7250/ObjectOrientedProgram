using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPrograms.StockManagement
{
    internal class Stock1
    {
        List<StockDetails> StockDetails = new List<StockDetails>();
        public void ReadJsonFile(string filename)
        {
            using (StreamReader reader = new StreamReader(filename))
            {
                var Json = reader.ReadToEnd();
                this.StockDetails = JsonConvert.DeserializeObject<List<StockDetails>>(Json);
                Console.WriteLine("Name" + "\t" + "NumberOfShare" + "\t" + "PricePerShare" + "\t" + "TotalSharePrice");
                foreach (var data in StockDetails)
                {
                    Console.WriteLine(data.Name + "\t" + data.NumberOfShare + "\t" + data.PricePerShare + "\t" + data.NumberOfShare * data.PricePerShare);
                }
            }
        }
    }
}
