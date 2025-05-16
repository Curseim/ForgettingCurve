using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForgettingCurve.Class.Data
{
    public class DataEntryModel
    {
        static public string KEY_FORMAT { get { return "yyyy-MM-dd-HH:mm:ss"; } }

        public string FirstEntryTime { get; set; }
        public string LastEntryTime { get; set; }
        public int ForgCurvLevel {  get; set; }
        public double ForgCurvScalar { get; set; }
        public double RemembrRatio { get; set; }
        public string Title { get; set; }
        public string Contents { get; set; }

        [JsonIgnore]
        public string Key => FirstEntryTime;
    }

}
