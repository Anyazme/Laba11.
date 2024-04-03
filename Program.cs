using ClassLibrary1;
using System;
using System.Collections;

namespace laba11 {
	internal class Program
	{
		static void Main(string[] args)
		{
			//ЗАДАНИЕ 1
			Console.WriteLine("ЗАДАНИЕ 1");
			Console.WriteLine();
			#region ArrayList 
			//ArrayList

			ArrayList arrayList = new ArrayList();
			for (int i = 0; i < 5; i++)
			{
				Aircraft a = new Aircraft();
				arrayList.Add(a);
				a.RandomInit();
			}
			for (int i = 0; i < 5; i++)
			{
				Plane p = new Plane();
				p.RandomInit();
				arrayList.Add(p);
			}
			for (int i = 0;i < 5; i++)
			{
				Helicopter h = new Helicopter();
				h.RandomInit();
				arrayList.Add(h);
			}

			arrayList.Sort();
			foreach (object a in arrayList)
			{
				Console.WriteLine(a.ToString());
			}
			Console.WriteLine($"Count = {arrayList.Count}");
			Console.WriteLine($"Capacity = {arrayList.Capacity}");

			//поиск и удаление
			Console.WriteLine("Введите, пожалуйста, элемент для поиска");
			Aircraft aircraft = new Aircraft();
			aircraft.Init();
			int pos = arrayList.IndexOf(aircraft);
			if(pos >= 0)
			{
				Console.WriteLine($"Удаляем {arrayList[pos]}");
				arrayList.RemoveAt(pos);
			}
			if (arrayList.Contains(aircraft))
			{
				Console.WriteLine("Найден");
			}
			else
			{
				Console.WriteLine("Не найден");
			}
			#endregion


		}
	}
}