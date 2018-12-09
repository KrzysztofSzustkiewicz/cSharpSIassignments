using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace CarRace
{
    internal class Program
    {
        /**
        * Creates all the vehicles that will be part of this race.
        */
        private static void CreateVehicles(Race race)
        {
            var listOfVehicles = new List<Vehicle>();
            var types = Assembly.GetExecutingAssembly().GetTypes();
            var possibleVehicleTypes = (from Type type in types where type.IsSubclassOf(typeof(Vehicle)) select type).ToArray();
            
            foreach (var vehicleType in possibleVehicleTypes)
            {
                
                for (var i = 0; i < 10; i++)
                {
                    listOfVehicles.Add(Activator.CreateInstance(vehicleType) as Vehicle);
                }
                
            }

            race.Vehicles = listOfVehicles.ToArray();
        }

        /**
         * Entry point of our program. Creates one race instance and
         * uses that.
         * <p>
         *
         * @param args commandline arguments passed to the program.
         *             It is unused.
         */
        
        public static void Main(string[] args)
        { 
            var race = new Race();
            CreateVehicles(race);
            race.SimulateRace();
            race.PrintRaceResults();
        }
    }
}