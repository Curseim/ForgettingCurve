using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;
using System.Web;

namespace ForgettingCurve.Class.Data
{
    public static class FileManager
    {
        public static void SaveToFile(string _path, List<DataEntryModel> _dataEntries)
        {
            string _json = JsonConvert.SerializeObject(_dataEntries, Formatting.Indented);
            File.WriteAllText(_path, _json);
        }

        public static void AppendToFile(string  _path, DataEntryModel _newEntry)
        {
            var _data = LoadFromFile(_path);
            _data.Add(_newEntry);
            SaveToFile(_path, _data);
        }

        public static List<DataEntryModel> LoadFromFile(string _path)
        {
            if (File.Exists(_path) == false)
                return new List<DataEntryModel>();

            string _json = File.ReadAllText(_path);
            return JsonConvert.DeserializeObject<List<DataEntryModel>>(_json);
        }

        // ex) FileManager.DeleteDataEntry(path, x => x.FirstTime == "2025-05-01-12:00:00");
        public static void DeleteDataEntry(string _path, Func<DataEntryModel, bool> _predicate)
        {
            var _data = LoadFromFile(_path);
            _data = _data.Where(x => _predicate(x)).ToList();
            SaveToFile(_path, _data);
        }
    }
}
