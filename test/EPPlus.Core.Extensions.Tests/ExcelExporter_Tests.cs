using System;
using System.Linq;
using System.Reflection;

using FluentAssertions;

using OfficeOpenXml;

using Xunit;

namespace EPPlus.Core.Extensions.Tests
{
    public class ExcelExporter_Tests
    {
        [Fact(Skip = "Not implemented yet")]
        public void Should_generate_an_Excel_package_from_given_ExcelExportable_class_name()
        {
            //-----------------------------------------------------------------------------------------------------------
            // Arrange
            //-----------------------------------------------------------------------------------------------------------
            Assembly executingAssembly = Assembly.GetExecutingAssembly();
            Type firstType = executingAssembly.FindExcelExportableTypes().First();

            //-----------------------------------------------------------------------------------------------------------
            // Act
            //-----------------------------------------------------------------------------------------------------------
            ExcelPackage excelPackage = ExcelExporter.GetExcelPackage(executingAssembly, firstType.Name);

            //-----------------------------------------------------------------------------------------------------------
            // Assert
            //-----------------------------------------------------------------------------------------------------------
            excelPackage.Should().NotBe(null);
            excelPackage.GetWorksheet(1).Should().NotBe(null);
        }
    }
}
