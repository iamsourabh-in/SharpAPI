using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataModel.UnitOfWork
{
    public interface IUnitOfWork
    {
        /// <summary>  
        /// Save method.  
        /// </summary>  
        void Save();
        IEnumerable<T> ExecWithStoreProcedure<T>(string sql, params object[] parameters);

    }
}
