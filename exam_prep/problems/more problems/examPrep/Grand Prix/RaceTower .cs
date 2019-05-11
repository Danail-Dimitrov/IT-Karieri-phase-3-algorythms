using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Grand_Prix
{
    static class RaceTower
    {
        private static Dictionary<string, Driver> drivers;
        private static int laps;
        private static int trackLength;
        private static int curentLap;

        public static int Laps
        {
            get => laps;
            private set => laps = value;
        }
        public static int TrackLength
        {
            get => trackLength;
            private set => trackLength = value;
        }
        public static Dictionary<string, Driver> Drivers
        {
            get => drivers;
            private set => drivers = value;
        }

        public static void SetTrackInfo (int lapsNumber, int trackLength)
        {
            Laps = lapsNumber;
            TrackLength = trackLength;
        }
        public static void RegisterDriver (List<string> commandArgs)
        {
            if(commandArgs.Count < 8)
            {
                commandArgs.Add("-1");
            }
            var driver = new Driver(commandArgs[1], commandArgs[2], int.Parse(commandArgs[3]),
            double.Parse(commandArgs[4]), double.Parse(commandArgs[6]), double.Parse(commandArgs[7]));

            drivers.Add(commandArgs[2], driver);
        }

        public static void DriverBoxes (List<string> commandArgs)
        {
            //TODO: Add some logic here …
        }

        public static void CompleteLaps (List<string> commandArgs)
        {
            int numberOfLaps = int.Parse(commandArgs[1]);
            if(numberOfLaps > laps)
            {
                throw new ArgumentException("invalid number of laps");
            }


        }

        public static string GetLeaderboard ()
        {
            string toReturn = null;
            toReturn = $"Lap {curentLap}/{laps} /n";
            drivers.OrderBy(name => name.Value.TotalTime);
            foreach(var pair in drivers)
            {
                int position = 1;
                toReturn += $"{position} {pair.Value.Name}";
                if(pair.Value.FailureReason != null)
                {
                    toReturn += $"{pair.Value.TotalTime}";
                }
                else
                {
                    toReturn += $"{pair.Value.FailureReason}";
                }
            }
            return toReturn;
        }

        public static void ChangeWeather (List<string> commandArgs)
        {
            //TODO: Add some logic here …
        }
    }
}
