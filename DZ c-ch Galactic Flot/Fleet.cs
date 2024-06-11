using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_c_ch_Galactic_Flot
{
    public class Fleet: IFleetOperations
    {
        public List<Spaceship> FleetSpaceships = new List<Spaceship>();

        public List<Mission> missions = new List<Mission>();




        public void AddSpaceship(string idSpaceship,string name, string model, decimal price)
        {
            FleetSpaceships.Add(new Spaceship { IDSpaceship = idSpaceship, Name = name, Model = model, Price = price });

        }

        public void RemoveSpaceship(Spaceship spaceship)
        {
            FleetSpaceships.Remove(spaceship);

        }

        public void AddMission(string idMission, string nameMission, string targetMission, DateTime startTime)
        {
            missions.Add(new Mission {  IDMission = idMission, NameMission = nameMission, TargetMission = targetMission, StartTime = startTime });

        }

        public void RemoveMission(string idMission)
        {
            var singlMission = missions.Where(m => m.IDMission == idMission).ToList();     
            singlMission.Clear();
        }


    }
}
