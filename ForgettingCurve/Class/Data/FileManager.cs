using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;
using System.Web;
using ForgettingCurve.Class.Data.Repository;
using System.Windows.Forms.VisualStyles;

namespace ForgettingCurve.Class.Data
{
    public static class FileManager
    {
        public static void SaveToFile(string _path, List<DataEntryModel> _dataEntries)
        {
            string _json = JsonConvert.SerializeObject(_dataEntries, Formatting.Indented);
            File.WriteAllText(_path, _json);
        }
        public static void SaveToFile(string _path, DataEntryModel _dataEntries)
        {
            string _json = JsonConvert.SerializeObject(_dataEntries, Formatting.Indented);
            File.WriteAllText(_path, _json);
        }

        public static void AppendToFile(string  _path, List<DataEntryModel> _newEntries)
        {
            var _data = LoadFromFile(_path);
            foreach (DataEntryModel _entry in _newEntries)
                _data.Add(_entry);
            SaveToFile(_path, _data);
        }
        public static void AppendToFile(string _path, DataEntryModel _newEntry)
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
            if (string.IsNullOrEmpty(_json))
                return new List<DataEntryModel>();
            else
                return JsonConvert.DeserializeObject<List<DataEntryModel>>(_json);
        }

        // ex) FileManager.DeleteDataEntry(_path, x => x.FirstTime == "2025-05-01-12:00:00");
        public static void DeleteDataEntry(string _path, Func<DataEntryModel, bool> _predicate)
        {
            var _data = LoadFromFile(_path);
            _data = _data.Where(x => !_predicate(x)).ToList();
            SaveToFile(_path, _data);
        }


    }

    public class DataRepository : IDataRepository
    {
        private readonly string path;
        private List<DataEntryModel> _dataEntries;

        public DataRepository(string p_path)
        {
            this.path = p_path;
            _dataEntries = FileManager.LoadFromFile(this.path);
        }

        public List<DataEntryModel> GetAll()
            => _dataEntries;

        public void Add(DataEntryModel _dataEntry)
            => _dataEntries.Add(_dataEntry);

        public void Delete(Func<DataEntryModel, bool> _predicate)
            => _dataEntries = _dataEntries.Where(x => !_predicate(x)).ToList();

        public void Save()
            => FileManager.SaveToFile(this.path, _dataEntries);


        public List<DataEntryModel> Search(Func<DataEntryModel, bool> _predicate)
        { 
            return _dataEntries.Where(x => _predicate(x)).ToList(); 
        }

        public void Modify(Func<DataEntryModel, bool> _predicate, DataEntryModel _dataEntry)
        {
            _dataEntries[_dataEntries.FindIndex(x => _predicate(x))] = _dataEntry;
        }
    }
}
