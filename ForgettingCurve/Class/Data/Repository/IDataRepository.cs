using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForgettingCurve.Class.Data.Repository
{
    public interface IDataRepository
    {
        List<DataEntryModel> GetAll();

        void Add(DataEntryModel _entry);
        
        void Delete(Func<DataEntryModel, bool> _predicate);

        void Save();

        List<DataEntryModel> Search(Func<DataEntryModel, bool> _predicate);

        void Modify(Func<DataEntryModel, bool> _predicate, DataEntryModel _entry);
    }
}
