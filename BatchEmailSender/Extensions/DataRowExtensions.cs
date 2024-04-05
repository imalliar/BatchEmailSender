using System.Data;
using System.Dynamic;

namespace BatchEmailSender.Extensions;

public static class DataRowExtensions
{
    public static IEnumerable<dynamic> ToDynamic(this DataTable dt)
    {
        foreach (DataRow row in dt.Rows)
        {
            var expandoDict = new ExpandoObject() as IDictionary<string, object?>;

            foreach (DataColumn col in dt.Columns)
            {
                var value = row[col.ColumnName];
                expandoDict.Add(col.ToString(), Convert.IsDBNull(value) ? null : value);
            }
            yield return expandoDict;
        }
    }
}
