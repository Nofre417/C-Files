using System;
using static System.Console;
using System.Reflection;

Clear();

// System.Data.DataSet ds;
// HttpClient client;

// Технология "Отражения" (System.Reflection)
Assembly? assembly = Assembly.GetEntryAssembly();
if (assembly == null) return;

// Перебор сборок на которые ссылкается приложение 
foreach (AssemblyName name in assembly.GetReferencedAssemblies())
{
    // Загрузка сборки для чтения данных
    Assembly a = Assembly.Load(name);


    // Переменная для подсчета количества методов
    int methodCount = 0;

    // Перебор всех типов в сборке
    foreach (TypeInfo t in a.DefinedTypes)
    {
        // Добавляем количество методов
        methodCount += t.GetMethods().Count();
    }

    // Вывод количества типов и их методов
    WriteLine("{0:N0} types with {1:N0} methods in {2} assembly.",
     arg0: a.DefinedTypes.Count(),
     arg1: methodCount, arg2: name.Name);

}