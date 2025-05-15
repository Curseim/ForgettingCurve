using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForgettingCurve.Class.Data.Repository
{
    public interface IDataRepository
    {
        IReadOnlyList<DataEntryModel> GetAll();

        void Add(DataEntryModel _entry);
        
        void Delete(Func<DataEntryModel, bool> _predicate);

        void Save();

        IReadOnlyList<DataEntryModel> Search(Func<DataEntryModel, bool> _predicate);
    }
}
