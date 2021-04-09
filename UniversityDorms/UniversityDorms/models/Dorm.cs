using System;
using System.Collections.Generic;
using System.Text;

namespace UniversityDorms.models
{
    public partial class Dorm
    {
        public string DormName { get; set; }
        public int NrOfRooms { get; set; }
        public string DormLocation { get; set; }
        public string PricePerMonth { get; set; }
        public int StudentPerRoom { get; set; }
        public int NrOfFlors { get; set; }
    }
}
