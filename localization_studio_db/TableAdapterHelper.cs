using System;
using System.Diagnostics;
using System.Linq;


namespace localization_studio_db
{
    public static class TableAdapterHelper
    {
        public static void FillAllTables(LocalizationDataSet dataSet, bool isAdmin)
        {
            if (dataSet == null) throw new ArgumentNullException(nameof(dataSet));

            try { new LocalizationDataSetTableAdapters.ДолжностьTableAdapter().Fill(dataSet.Должность); }
            catch (Exception ex) { Debug.WriteLine($"[Fill] Должность failed: {ex.Message}"); }

            try { new LocalizationDataSetTableAdapters.ПриоритетTableAdapter().Fill(dataSet.Приоритет); }
            catch (Exception ex) { Debug.WriteLine($"[Fill] Приоритет failed: {ex.Message}"); }

            try { new LocalizationDataSetTableAdapters.Статус_выполненияTableAdapter().Fill(dataSet.Статус_выполнения); }
            catch (Exception ex) { Debug.WriteLine($"[Fill] Статус_выполнения failed: {ex.Message}"); }

            try { new LocalizationDataSetTableAdapters.Уровень_языкаTableAdapter().Fill(dataSet.Уровень_языка); }
            catch (Exception ex) { Debug.WriteLine($"[Fill] Уровень_языка failed: {ex.Message}"); }

            try { new LocalizationDataSetTableAdapters.ЯзыкиTableAdapter().Fill(dataSet.Языки); }
            catch (Exception ex) { Debug.WriteLine($"[Fill] Языки failed: {ex.Message}"); }


            try { new LocalizationDataSetTableAdapters.Владение_языкамиTableAdapter().Fill(dataSet.Владение_языками); }
            catch (Exception ex) { Debug.WriteLine($"[Fill] Владение_языками failed: {ex.Message}"); }

            try { new LocalizationDataSetTableAdapters.ЗадачиTableAdapter().Fill(dataSet.Задачи); }
            catch (Exception ex) { Debug.WriteLine($"[Fill] Задачи failed: {ex.Message}"); }

            try { new LocalizationDataSetTableAdapters.КлиентыTableAdapter().Fill(dataSet.Клиенты); }
            catch (Exception ex) { Debug.WriteLine($"[Fill] Клиенты failed: {ex.Message}"); }

            try { new LocalizationDataSetTableAdapters.КонтрактыTableAdapter().Fill(dataSet.Контракты); }
            catch (Exception ex) { Debug.WriteLine($"[Fill] Контракты failed: {ex.Message}"); }

            try { new LocalizationDataSetTableAdapters.МедиаTableAdapter().Fill(dataSet.Медиа); }
            catch (Exception ex) { Debug.WriteLine($"[Fill] Медиа failed: {ex.Message}"); }

            try { new LocalizationDataSetTableAdapters.Проектные_командыTableAdapter().Fill(dataSet.Проектные_команды); }
            catch (Exception ex) { Debug.WriteLine($"[Fill] Проектные_команды failed: {ex.Message}"); }

            try { new LocalizationDataSetTableAdapters.Проектные_ролиTableAdapter().Fill(dataSet.Проектные_роли); }
            catch (Exception ex) { Debug.WriteLine($"[Fill] Проектные_роли failed: {ex.Message}"); }

            try { new LocalizationDataSetTableAdapters.ПроектыTableAdapter().Fill(dataSet.Проекты); }
            catch (Exception ex) { Debug.WriteLine($"[Fill] Проекты failed: {ex.Message}"); }

            try { new LocalizationDataSetTableAdapters.СловариTableAdapter().Fill(dataSet.Словари); }
            catch (Exception ex) { Debug.WriteLine($"[Fill] Словари failed: {ex.Message}"); }

            try { new LocalizationDataSetTableAdapters.СотрудникиTableAdapter().Fill(dataSet.Сотрудники); }
            catch (Exception ex) { Debug.WriteLine($"[Fill] Сотрудники failed: {ex.Message}"); }
        }

        public static void UpdateAllTables(LocalizationDataSet dataSet)
        {
            if (dataSet == null) throw new ArgumentNullException(nameof(dataSet));

            try { new LocalizationDataSetTableAdapters.Владение_языкамиTableAdapter().Update(dataSet.Владение_языками); }
            catch (Exception ex) { Debug.WriteLine($"[Update] Владение_языками failed: {ex.Message}"); }

            try { new LocalizationDataSetTableAdapters.ДолжностьTableAdapter().Update(dataSet.Должность); }
            catch (Exception ex) { Debug.WriteLine($"[Update] Должность failed: {ex.Message}"); }

            try { new LocalizationDataSetTableAdapters.ЗадачиTableAdapter().Update(dataSet.Задачи); }
            catch (Exception ex) { Debug.WriteLine($"[Update] Задачи failed: {ex.Message}"); }

            try { new LocalizationDataSetTableAdapters.КлиентыTableAdapter().Update(dataSet.Клиенты); }
            catch (Exception ex) { Debug.WriteLine($"[Update] Клиенты failed: {ex.Message}"); }

            try { new LocalizationDataSetTableAdapters.КонтрактыTableAdapter().Update(dataSet.Контракты); }
            catch (Exception ex) { Debug.WriteLine($"[Update] Контракты failed: {ex.Message}"); }

            try { new LocalizationDataSetTableAdapters.МедиаTableAdapter().Update(dataSet.Медиа); }
            catch (Exception ex) { Debug.WriteLine($"[Update] Медиа failed: {ex.Message}"); }

            try { new LocalizationDataSetTableAdapters.ПриоритетTableAdapter().Update(dataSet.Приоритет); }
            catch (Exception ex) { Debug.WriteLine($"[Update] Приоритет failed: {ex.Message}"); }

            try { new LocalizationDataSetTableAdapters.Проектные_командыTableAdapter().Update(dataSet.Проектные_команды); }
            catch (Exception ex) { Debug.WriteLine($"[Update] Проектные_команды failed: {ex.Message}"); }

            try { new LocalizationDataSetTableAdapters.Проектные_ролиTableAdapter().Update(dataSet.Проектные_роли); }
            catch (Exception ex) { Debug.WriteLine($"[Update] Проектные_роли failed: {ex.Message}"); }

            try { new LocalizationDataSetTableAdapters.ПроектыTableAdapter().Update(dataSet.Проекты); }
            catch (Exception ex) { Debug.WriteLine($"[Update] Проекты failed: {ex.Message}"); }

            try { new LocalizationDataSetTableAdapters.СловариTableAdapter().Update(dataSet.Словари); }
            catch (Exception ex) { Debug.WriteLine($"[Update] Словари failed: {ex.Message}"); }

            try { new LocalizationDataSetTableAdapters.СотрудникиTableAdapter().Update(dataSet.Сотрудники); }
            catch (Exception ex) { Debug.WriteLine($"[Update] Сотрудники failed: {ex.Message}"); }

            try { new LocalizationDataSetTableAdapters.Статус_выполненияTableAdapter().Update(dataSet.Статус_выполнения); }
            catch (Exception ex) { Debug.WriteLine($"[Update] Статус_выполнения failed: {ex.Message}"); }

            try { new LocalizationDataSetTableAdapters.Уровень_языкаTableAdapter().Update(dataSet.Уровень_языка); }
            catch (Exception ex) { Debug.WriteLine($"[Update] Уровень_языка failed: {ex.Message}"); }

            try { new LocalizationDataSetTableAdapters.ЯзыкиTableAdapter().Update(dataSet.Языки); }
            catch (Exception ex) { Debug.WriteLine($"[Update] Языки failed: {ex.Message}"); }
        }

        public static bool UpdateSingleTable(string tableName, LocalizationDataSet dataSet)
        {
            if (string.IsNullOrWhiteSpace(tableName) || dataSet == null)
                return false;

            try
            {
                switch (tableName)
                {
                    case "Владение_языками":
                        new LocalizationDataSetTableAdapters.Владение_языкамиTableAdapter().Update(dataSet.Владение_языками);
                        break;
                    case "Должность":
                        new LocalizationDataSetTableAdapters.ДолжностьTableAdapter().Update(dataSet.Должность);
                        break;
                    case "Задачи":
                        new LocalizationDataSetTableAdapters.ЗадачиTableAdapter().Update(dataSet.Задачи);
                        break;
                    case "Клиенты":
                        new LocalizationDataSetTableAdapters.КлиентыTableAdapter().Update(dataSet.Клиенты);
                        break;
                    case "Контракты":
                        new LocalizationDataSetTableAdapters.КонтрактыTableAdapter().Update(dataSet.Контракты);
                        break;
                    case "Медиа":
                        new LocalizationDataSetTableAdapters.МедиаTableAdapter().Update(dataSet.Медиа);
                        break;
                    case "Приоритет":
                        new LocalizationDataSetTableAdapters.ПриоритетTableAdapter().Update(dataSet.Приоритет);
                        break;
                    case "Проектные_команды":
                        new LocalizationDataSetTableAdapters.Проектные_командыTableAdapter().Update(dataSet.Проектные_команды);
                        break;
                    case "Проектные_роли":
                        new LocalizationDataSetTableAdapters.Проектные_ролиTableAdapter().Update(dataSet.Проектные_роли);
                        break;
                    case "Проекты":
                        new LocalizationDataSetTableAdapters.ПроектыTableAdapter().Update(dataSet.Проекты);
                        break;
                    case "Словари":
                        new LocalizationDataSetTableAdapters.СловариTableAdapter().Update(dataSet.Словари);
                        break;
                    case "Сотрудники":
                        new LocalizationDataSetTableAdapters.СотрудникиTableAdapter().Update(dataSet.Сотрудники);
                        break;
                    case "Статус_выполнения":
                        new LocalizationDataSetTableAdapters.Статус_выполненияTableAdapter().Update(dataSet.Статус_выполнения);
                        break;
                    case "Уровень_языка":
                        new LocalizationDataSetTableAdapters.Уровень_языкаTableAdapter().Update(dataSet.Уровень_языка);
                        break;
                    case "Языки":
                        new LocalizationDataSetTableAdapters.ЯзыкиTableAdapter().Update(dataSet.Языки);
                        break;
                    default:
                        return false;
                }

                return true;
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"[UpdateSingle] {tableName} failed: {ex.Message}");
                return false;
            }
        }

        public static void ClearAllTables(LocalizationDataSet dataSet)
        {
            if (dataSet == null) throw new ArgumentNullException(nameof(dataSet));

            dataSet.Владение_языками.Clear();
            dataSet.Должность.Clear();
            dataSet.Задачи.Clear();
            dataSet.Клиенты.Clear();
            dataSet.Контракты.Clear();
            dataSet.Медиа.Clear();
            dataSet.Приоритет.Clear();
            dataSet.Проектные_команды.Clear();
            dataSet.Проектные_роли.Clear();
            dataSet.Проекты.Clear();
            dataSet.Словари.Clear();
            dataSet.Сотрудники.Clear();
            dataSet.Статус_выполнения.Clear();
            dataSet.Уровень_языка.Clear();
            dataSet.Языки.Clear();
        }


    }
}


