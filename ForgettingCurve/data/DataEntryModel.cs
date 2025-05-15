using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForgettingCurve.Class.Data {
    public class DataEntryModel {
        public string FirstEntryTime { get; set; }
        public string LastEntryTime { get; set; }
        public int ForgCurvLevel { get; set; }
        public double ForgCurvScalar { get; set; }
        public double RemembrRatio { get; set; }
        public string Contents { get; set; }
    }
}