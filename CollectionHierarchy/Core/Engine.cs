using CollectionHierarchy.Models;
using System;

namespace CollectionHierarchy.Core
{
    public class Engine
    {
        public void Run()
        {
            AddCollection addColl = new AddCollection();
            AddRemoveCollection addRemoveColl = new AddRemoveCollection();
            MyList myList = new MyList();

            var input = Console.ReadLine().Split();

            foreach (var item in input)
            {
                Console.Write($"{addColl.Add(item)} ");
            }
            Console.WriteLine();

            foreach (var item in input)
            {
                Console.Write($"{addRemoveColl.Add(item)} ");
            }
            Console.WriteLine();

            foreach (var item in input)
            {
                Console.Write($"{myList.Add(item)} ");
            }
            Console.WriteLine();


            int count = int.Parse(Console.ReadLine());

            for (int i = 0; i < count; i++)
            {
                Console.Write($"{addRemoveColl.Remove()} ");
            }
            Console.WriteLine();

            for (int i = 0; i < count; i++)
            {
                Console.Write($"{myList.Remove()} ");
            }
            Console.WriteLine();


        }
    }
}
