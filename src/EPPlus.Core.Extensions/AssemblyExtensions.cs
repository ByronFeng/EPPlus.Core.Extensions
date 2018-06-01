using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace EPPlus.Core.Extensions
{
    public static class AssemblyExtensions
    {
        public static List<Type> FindExcelExportableTypes(this Assembly executingAssembly) => (from type in executingAssembly.GetTypes()
                                                                                          where typeof(IExcelExportable).IsAssignableFrom(type)
                                                                                          select type).ToList();

        public static List<string> GetNamesOfAllExcelExportableClasses(this Assembly executingAssembly)
        {
            return FindExcelExportableTypes(executingAssembly).Select(x => x.Name).ToList();
        }

        public static Type GetTypeByName(this Assembly executingAssembly, string nameOfFirstType)
        {
            return FindExcelExportableTypes(executingAssembly).FirstOrDefault(x => x.Name.Equals(nameOfFirstType, StringComparison.InvariantCultureIgnoreCase));
        }
    }
}
