namespace DZ_c_ch_Galactic_Flot
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            List<Fleet> fleets = new List<Fleet>();
            Fleet fleet1 = new Fleet();
            Fleet fleet2 = new Fleet();
            fleets.Add(fleet1);
            fleets.Add(fleet2);

            Spaceship Spship1 = new Spaceship("id-12457", "G-80", "T20", 57436 );
            Spaceship Spship2 = new Spaceship("id-17458", "G-81", "T20", 57436);
            Spaceship Spship3 = new Spaceship("id-12459", "G-82", "T20", 57436);
            Spaceship Spship4 = new Spaceship("id-14450", "G-83", "T20", 57436);
            Spaceship Spship5 = new Spaceship("id-17457", "G-84", "T20", 57436);
            Spaceship Spship6 = new Spaceship("id-15857", "G-20", "A1025",5457436);
            Spaceship Spship7 = new Spaceship("id-18455", "G-22", "B40", 80436);
            Spaceship Spship8 = new Spaceship("id-22447", "G-42", "BC40", 148436);

            fleet1.FleetSpaceships.Add(Spship1);
            fleet1.FleetSpaceships.Add(Spship2);
            fleet1.FleetSpaceships.Add(Spship3);
            fleet1.FleetSpaceships.Add(Spship4);
            fleet1.FleetSpaceships.Add(Spship5);
            fleet1.FleetSpaceships.Add(Spship6);
            fleet1.FleetSpaceships.Add(Spship7);
            fleet1.FleetSpaceships.Add(Spship8);
            
            DateTime dateTime1 = new DateTime(3014,12,4);
            Mission mission1 = new Mission {IDMission= "id-007", NameMission= "Part1", TargetMission = "Mars400", StartTime= dateTime1 };
            DateTime dateTime2 = new DateTime(3015, 10, 25);
            Mission mission2 = new Mission { IDMission = "id-008", NameMission = "Part2", TargetMission = "Mars400", StartTime = dateTime2 };
            fleet1.missions.Add(mission1);
            fleet1.missions.Add(mission2);

            fleet2.FleetSpaceships.Add(Spship3);
            fleet2.FleetSpaceships.Add(Spship4);
            fleet2.FleetSpaceships.Add(Spship5);
            fleet2.FleetSpaceships.Add(Spship6);

            DateTime dateTime3 = new DateTime(3017,2, 15);
            Mission mission3 = new Mission { IDMission = "id-009", NameMission = "Part3", TargetMission = "saturn-57", StartTime = dateTime1 };
            fleet2.missions.Add(mission3);

            foreach (var fleet in fleets)
            {
                var missionsship = DataFleet.GetMissionToShip("id-17457", fleet);
                if(missionsship != null)
                {
                    foreach (var ms in missionsship)
                    {
                        Console.WriteLine($"IDMission: {ms.IDMission},NameMission: {ms.NameMission}, " +
                           $"TargetMission: {ms.TargetMission},StartTime: {ms.StartTime}");

                    }
                }
                
            }

            DataFleet.SaveToFile(fleet1.missions, "fleet1_missions.json");
            DataFleet.SaveToFile(fleet1.FleetSpaceships, "fleet1_Spaceships.json");






        }
    }
}
