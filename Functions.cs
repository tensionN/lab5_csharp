using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    public class Functions
    {
        public static void ReadFile(string path, List<Medicine> medicines)
        {
            try
            {
                using (StreamReader reader = new StreamReader(path, System.Text.Encoding.UTF8))
                {
                    string? line = reader.ReadLine();

                    while ((line != null))
                    {
                        if (medicines.Count != 0)
                            line = reader.ReadLine();

                        if (line == "")
                            break;
                        Medicine item = new Medicine();
                        item.Name = line;

                        line = reader.ReadLine();
                        item.ExpirationDate = System.Convert.ToInt32(line);
                        line = reader.ReadLine();
                        item.ProductionDate = DateTime.Parse(line);
                        line = reader.ReadLine();
                        item.Count = System.Convert.ToInt32(line);
                        line = reader.ReadLine();
                        item.Price = System.Convert.ToDouble(line);

                        medicines.Add(item);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
