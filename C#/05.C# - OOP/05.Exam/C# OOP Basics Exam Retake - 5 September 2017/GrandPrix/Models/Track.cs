using System;
using System.Collections.Generic;
using System.Text;

namespace GrandPrix.Models
{
    public class Track
    {
        public Track(int totalLaps, int length)
        {
            this.TotalLaps = totalLaps;
            this.Length = length;
        }
        public int TotalLaps { get; }
        public int Length { get; }
        public int CurrentLap { get; set; }
        public string Weather { get; set; }
    }
}
