using System;
using System.Linq;


namespace localization_studio_db
{
    public static class TableAdapterHelper
    {
        public static void FillAllTables(object dataSet)
        {
            if (dataSet == null) throw new ArgumentNullException(nameof(dataSet));

            var dataSetType = dataSet.GetType();
            var adapterNamespace = $"{dataSetType.Namespace}TableAdapters";
            var adapterTypes = dataSetType.Assembly.GetTypes()
                .Where(t => t.IsClass && t.Namespace == adapterNamespace && t.Name.EndsWith("TableAdapter"));

            foreach (var adapterType in adapterTypes)
            {
                try
                {
                    var adapter = Activator.CreateInstance(adapterType);
                    var tableName = adapterType.Name.Replace("TableAdapter", "");
                    var tableProperty = dataSetType.GetProperty(tableName);
                    var dataTable = tableProperty?.GetValue(dataSet);

                    var fillMethod = adapterType.GetMethod("Fill");
                    fillMethod?.Invoke(adapter, new object[] { dataTable });
                }
                catch (Exception ex)
                {
                    System.Diagnostics.Debug.WriteLine($"[Fill] {adapterType.Name} failed: {ex.Message}");
                }
            }
        }

        public static void UpdateAllTables(object dataSet)
        {
            if (dataSet == null) throw new ArgumentNullException(nameof(dataSet));

            var dataSetType = dataSet.GetType();
            var adapterNamespace = $"{dataSetType.Namespace}TableAdapters";
            var adapterTypes = dataSetType.Assembly.GetTypes()
                .Where(t => t.IsClass && t.Namespace == adapterNamespace && t.Name.EndsWith("TableAdapter"));

            foreach (var adapterType in adapterTypes)
            {
                try
                {
                    var adapter = Activator.CreateInstance(adapterType);
                    var tableName = adapterType.Name.Replace("TableAdapter", "");
                    var tableProperty = dataSetType.GetProperty(tableName);
                    var dataTable = tableProperty?.GetValue(dataSet);

                    var updateMethod = adapterType.GetMethod("Update", new[] { dataTable.GetType() });
                    updateMethod?.Invoke(adapter, new object[] { dataTable });
                }
                catch (Exception ex)
                {
                    System.Diagnostics.Debug.WriteLine($"[Update] {adapterType.Name} failed: {ex.Message}");
                }
            }
        }
    }
}


