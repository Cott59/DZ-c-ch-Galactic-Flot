using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_c_ch_Galactic_Flot
{
    public struct Spaceship
    {
        public string IDSpaceship { get; set; }
        public string Name { get; set; }
        public string Model { get; set; }
        public decimal Price {  get; set; }

        public Spaceship(string idSpaceship, string name, string model, decimal price) 
        {
            IDSpaceship = idSpaceship;
            Name = name;
            Model = model;
            Price = price;
        }
    }


    public struct Mission
    {
        public string IDMission { get; set; }
        public string NameMission { get; set; }
        public string TargetMission { get; set; }
        public DateTime StartTime { get; set; }
    }



}
