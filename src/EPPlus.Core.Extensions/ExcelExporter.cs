using System;
using System.Reflection;

using OfficeOpenXml;

namespace EPPlus.Core.Extensions
{
    public static class ExcelExporter
    {
        public static ExcelPackage GetExcelPackage(Assembly executingAssembly, string typeName)
        {
            Type type = executingAssembly.GetTypeByName(typeName);

            return null;
        }

        public static ExcelPackage GetExcelPackage(string typeName) => GetExcelPackage(Assembly.GetExecutingAssembly(), typeName);
    }
}
