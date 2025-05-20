using System;
using System.Diagnostics;
using System.Linq;


namespace localization_studio_db
{
    public static class TableAdapterHelper
    {
        public static void FillAllTables(LocalizationDataSet dataSet)
        {
            if (dataSet == null) throw new ArgumentNullException(nameof(dataSet));

            try { new LocalizationDataSetTableAdapters.Вид_медиаTableAdapter().Fill(dataSet.Вид_медиа); }
            catch (Exception ex) { Debug.WriteLine($"[Fill] Вид_медиа failed: {ex.Message}"); }

            try { new LocalizationDataSetTableAdapters.Владение_языкамиTableAdapter().Fill(dataSet.Владение_языками); }
            catch (Exception ex) { Debug.WriteLine($"[Fill] Владение_языками failed: {ex.Message}"); }

            try { new LocalizationDataSetTableAdapters.ДолжностьTableAdapter().Fill(dataSet.Должность); }
            catch (Exception ex) { Debug.WriteLine($"[Fill] Должность failed: {ex.Message}"); }

            try { new LocalizationDataSetTableAdapters.ЗадачиTableAdapter().Fill(dataSet.Задачи); }
            catch (Exception ex) { Debug.WriteLine($"[Fill] Задачи failed: {ex.Message}"); }

            try { new LocalizationDataSetTableAdapters.КлиентыTableAdapter().Fill(dataSet.Клиенты); }
            catch (Exception ex) { Debug.WriteLine($"[Fill] Клиенты failed: {ex.Message}"); }

            try { new LocalizationDataSetTableAdapters.КонтрактыTableAdapter().Fill(dataSet.Контракты); }
            catch (Exception ex) { Debug.WriteLine($"[Fill] Контракты failed: {ex.Message}"); }

            try { new LocalizationDataSetTableAdapters.МедиаTableAdapter().Fill(dataSet.Медиа); }
            catch (Exception ex) { Debug.WriteLine($"[Fill] Медиа failed: {ex.Message}"); }

            try { new LocalizationDataSetTableAdapters.ПриоритетTableAdapter().Fill(dataSet.Приоритет); }
            catch (Exception ex) { Debug.WriteLine($"[Fill] Приоритет failed: {ex.Message}"); }

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

            try { new LocalizationDataSetTableAdapters.Статус_выполненияTableAdapter().Fill(dataSet.Статус_выполнения); }
            catch (Exception ex) { Debug.WriteLine($"[Fill] Статус_выполнения failed: {ex.Message}"); }

            try { new LocalizationDataSetTableAdapters.Статус_документацииTableAdapter().Fill(dataSet.Статус_документации); }
            catch (Exception ex) { Debug.WriteLine($"[Fill] Статус_документации failed: {ex.Message}"); }

            try { new LocalizationDataSetTableAdapters.Статус_оплатыTableAdapter().Fill(dataSet.Статус_оплаты); }
            catch (Exception ex) { Debug.WriteLine($"[Fill] Статус_оплаты failed: {ex.Message}"); }

            try { new LocalizationDataSetTableAdapters.Уровень_языкаTableAdapter().Fill(dataSet.Уровень_языка); }
            catch (Exception ex) { Debug.WriteLine($"[Fill] Уровень_языка failed: {ex.Message}"); }

            try { new LocalizationDataSetTableAdapters.ЯзыкиTableAdapter().Fill(dataSet.Языки); }
            catch (Exception ex) { Debug.WriteLine($"[Fill] Языки failed: {ex.Message}"); }
        }

        public static void UpdateAllTables(LocalizationDataSet dataSet)
        {
            if (dataSet == null) throw new ArgumentNullException(nameof(dataSet));

            try { new LocalizationDataSetTableAdapters.Вид_медиаTableAdapter().Update(dataSet.Вид_медиа); }
            catch (Exception ex) { Debug.WriteLine($"[Update] Вид_медиа failed: {ex.Message}"); }

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

            try { new LocalizationDataSetTableAdapters.Статус_документацииTableAdapter().Update(dataSet.Статус_документации); }
            catch (Exception ex) { Debug.WriteLine($"[Update] Статус_документации failed: {ex.Message}"); }

            try { new LocalizationDataSetTableAdapters.Статус_оплатыTableAdapter().Update(dataSet.Статус_оплаты); }
            catch (Exception ex) { Debug.WriteLine($"[Update] Статус_оплаты failed: {ex.Message}"); }

            try { new LocalizationDataSetTableAdapters.Уровень_языкаTableAdapter().Update(dataSet.Уровень_языка); }
            catch (Exception ex) { Debug.WriteLine($"[Update] Уровень_языка failed: {ex.Message}"); }

            try { new LocalizationDataSetTableAdapters.ЯзыкиTableAdapter().Update(dataSet.Языки); }
            catch (Exception ex) { Debug.WriteLine($"[Update] Языки failed: {ex.Message}"); }
        }

    }
}


