using Matrixsoft.Framework.DapperExtensions.Sql;
using System.Collections.Generic;

namespace Matrixsoft.Framework.DapperExtensions.Predicate
{
    public interface IPredicate
    {
        string GetSql(ISqlGenerator sqlGenerator, IDictionary<string, object> parameters, bool isDml = false);
    }
}
