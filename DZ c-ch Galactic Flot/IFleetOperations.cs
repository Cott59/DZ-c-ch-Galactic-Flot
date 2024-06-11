using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_c_ch_Galactic_Flot
{
    public interface IFleetOperations
    {
        //добавление корабля, удаление корабля, назначение миссии

        void AddSpaceship(string idSpaceship, string name, string model, decimal price);

        void RemoveSpaceship(Spaceship spaceship);

        void AddMission(string idMission, string nameMission, string targetMission, DateTime startTime);

        void RemoveMission(string idMission);    

    }
}
