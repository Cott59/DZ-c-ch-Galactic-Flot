using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_c_ch_Galactic_Flot
{
    public class DataFleet
    {

        // Реализуйте метод для поиска кораблей по заданному критерию(например, по модели или диапазону стоимости) с использованием LINQ.
        public static List<Spaceship> GetSpaceshipToModel(string model,List<Spaceship> fleetSpaceships)
        {
            return fleetSpaceships.Where(m => m.Model == model).ToList();

        }
        public static List<Spaceship> GetSpaceshipToPrice(int numMin, int numMax, List<Spaceship> fleetSpaceships)
        {

            return fleetSpaceships.Where(m=>m.Price>=numMin&& m.Price<=numMax).ToList();

        }

        public static IEnumerable<Mission> GetMissionToShip(string idShip, Fleet fleets)
        {
            var oneShip = fleets.FleetSpaceships.Where(n => n.IDSpaceship == idShip).ToList();
            if (oneShip.Count > 0)
            {
                return fleets.missions;
            }
            else
                return null;   

        }

        public static string SerializeObject<T>(T obj)
        {
            return JsonConvert.SerializeObject(obj, Formatting.Indented);

        }

        public static T DeserializeObject<T>(string json)
        {
            return JsonConvert.DeserializeObject<T>(json);
        }
        public static void SaveToFile<T>(T obj, string filePath)
        {
            var json = SerializeObject(obj);
            File.WriteAllText(filePath, json);
        }
        public static T LoadFromFile<T>(string filePath)
        {
            var json = File.ReadAllText(filePath);
            return DeserializeObject<T>(json);

        }



    }
}
