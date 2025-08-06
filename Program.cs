using System.Collections;
using System.Collections.Generic;

namespace CS_AdvSesstion03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Some Informations
            //Any Collection bigins with 'sorted' Depends on IComparable<> or IComparer<>
            //The Other Collections Depends on Equals(),GetHashCode() (form object or IEquatable<>or IEqualityComparer<>)
            #endregion
            #region HashTable
            Hashtable StdGrade = new Hashtable
            {
                {"Ahmed", 100 },
                {"Ali", 99 },
                {"Nora", 90 },
                {"ahmed" ,55}, // it will accept adding this like it is a different element(we will prevent this by using another ctor overload)
                {1,"ali" },
                {2,"Rana" }, // It does not mind adding those (Because it sotres objects)
                {3,"Mira" }
            };

            #region Iteration
            //foreach (DictionaryEntry item in StdGrade)
            //Console.WriteLine(item); // Get the data rondomly

            //------------------------------------------------------
            //foreach (DictionaryEntry item in StdGrade)
            //Console.WriteLine(item.Key); // Get the data rondomly
            //------------------------------------------------------

            //foreach (DictionaryEntry item in StdGrade)
            //    Console.WriteLine(item.Value); // Get the data rondomly
            //------------------------------------------------------

            //foreach(int value in StdGrade.Values )
            //    Console.WriteLine($"{value}");
            //------------------------------------------------------

            //foreach(string key in StdGrade.Keys )
            //    Console.WriteLine($"{key}");
            //------------------------------------------------------


            #endregion
            #region Indexer
            //Printing
            //Console.WriteLine(StdGrade["ahmed"]);

            //Modifing
            //StdGrade["Ahmed"] = 30;   // Updating if it exits Inserting if it does not. 
            //Console.WriteLine(StdGrade["Ahmed"]);

            #endregion

            // That Version Know that Ahmed and ahmed are the same
            Hashtable StdGrade02 = new Hashtable(new StringEqualityComparerNonGeneric())
            {
                {"Ahmed", 100 },
                {"Ali", 99 },
                {"Nora", 90 },
                //{"ahmed" ,55}
            };




            #endregion
            #region Dictionary
            #region Example01
            Dictionary<string, int> StdGradeDict = new Dictionary<string, int>
              {
                  {"Ahmed", 100 },
                  {"Ali", 99 },
                  {"Nora", 90 },
                   {"ahmed", 55 }
              };

            #region TryGetValue
            //bool result = StdGradeDict.TryGetValue("ali", out int value);
            //Console.WriteLine($"{result},{value}"); 
            #endregion
            #region TryAdd
            //bool isAdd= StdGradeDict.TryAdd("ahmed", 333);
            // Console.WriteLine(isAdd);
            #endregion
            #region Iteration
            //foreach (KeyValuePair<string,int> item in StdGradeDict)
            //    Console.WriteLine(item);
            //--------------------------------------------
            //foreach (var key in StdGradeDict.Keys)
            //    Console.WriteLine(key);
            //---------------------------------------------
            //foreach (var value in StdGradeDict.Values)
            //    Console.WriteLine(value);
            #endregion
            #region Indexer
            //Console.WriteLine(StdGradeDict["Ahmed"]);
            //StdGradeDict["Ahmed"] = 30;
            #endregion
            #region ContainsKey
            if (!StdGradeDict.ContainsKey("Ahmed"))
            {
                StdGradeDict.Add("Ahmed", 22);
            }
            #endregion
            #endregion
            #region Example02
            // That Version Know that Ahmed and ahmed are the same
            Dictionary<string, int> StdGradeDict02 = new Dictionary<string, int>(new StringEqualityComparer())
              {
                  {"Ahmed", 100 },
                  {"Ali", 99 },
                  {"Nora", 90 },
                  // {"ahmed", 55 } // It will throw an exception if you add this 
              };

            #endregion
            #region Exmaple03
            // Comparing based on object state (I overrided Equals() & GetHashCode())
            Employee emp01 = new Employee(1, "ahmed", 8000);
            Employee emp02 = new Employee(4, "ali", 4000);
            Employee emp03 = new Employee(3, "nora",5000); 
            Employee emp04 = new Employee(3, "nora",5000); 
            Employee emp05 = new Employee(4, "nora",5000); 
            Dictionary<Employee,int> EmpRank= new Dictionary<Employee, int>
            {
                { emp01, 1 },
                { emp02, 2 },
                { emp03, 3 },
                //{ emp04, 4 },
                { emp05, 5 }
            };
         // Comparing based on Id
            Dictionary<Employee,int> EmpRank02= new Dictionary<Employee, int>(new IdEqualityComparer())
            {
                { emp01, 1 },
                { emp02, 2 },
                { emp03, 3 },
                //{ emp04, 4 },
                { emp05, 5 }
            };
            #endregion
            #endregion
            #region SortedDictionary
            #region Example01
            SortedDictionary<string, int> StdGrades = new SortedDictionary<string, int>()
            {
                {"samar",66 },
                {"khaled",77 },
                {"ali",55 },
                {"Amir",56 },
                {"ahmed",33 }

            };
            //foreach (var item in StdGrades)
            //{
            //    Console.WriteLine(item);
            //}
            SortedDictionary<string, int> StdGrades02 = new SortedDictionary<string, int>(new StringComparer())
            {
                {"samar",66 },
                {"khaled",77 },
                {"ali",55 },
                {"Amir",56 },
                {"ahmed",33 }

            };
            //foreach (var item in StdGrades02)
            //{
            //    Console.WriteLine(item);
            //} 
            #endregion
            #region Example02
            // SortedDictionary of user definded Data type
            // this data type must be implementing IComparable<this type> for default bevaior 
            // or implement ICompare<this type> for Custome Behaviors

            SortedDictionary<Employee,int> EmployeesRank = new SortedDictionary<Employee, int>()
            {
                [new Employee(4,"nora",6000)]=6,
                [new Employee(1,"hamed",4000)]=1,
                [new Employee(2,"ahmed",4000)]=2,

            };
            //foreach (var emp in EmployeesRank)
            //{
            //    Console.WriteLine($"{emp}");
            //}
            #endregion

            #endregion
            #region SortedList
            //The Same as SortedDictionay but , it depends internally on two arrays one for keys and one for values
            // SortedList of user definded Data types=>
            // this data type must be implementing IComparable<this type> for default bevaior ,
            // or implement IComparer<this type> for Custome behaviors

            //It has another index (Which we can access Via methods like GetValueAtIndex(i),GetKeyAtIndex(i),SetValueAtIndex()/*Updates the value*/)
            #endregion
            #region HashSet
            // It Ignores Duplicate keys Which means the elements are Distinct(Unique)
            HashSet<string> names = new HashSet<string>(new StringEqualityComparer())
            {
                "hamed","ali","nora","Ahmed","Nour","Khalid","ahmed"
            };
            //foreach (string name in names)
            //{
            //    Console.WriteLine(name);
            //}

            HashSet<int> NumbersSet01 = [1, 2, 3, 4, 5, 6, 7, 8,];
            HashSet<int> NumbersSet02 = [1, 2, 3, 66,77,88];
            //Some ISet Methods//
            //NumbersSet01.UnionWith(NumbersSet02);
            //NumbersSet01.Add(-3);
            //NumbersSet01.IntersectWith(NumbersSet02);
            //NumbersSet01.ExceptWith(NumbersSet02); //Non Common Element
            //NumbersSet01.SymmetricExceptWith(NumbersSet02);

            //foreach (var num in NumbersSet01)
            //{
            //    Console.WriteLine($"{num} ");
            //}

            #endregion
            #region SortedSet
            #region primitive Data type
            #region inOrder

            SortedSet<int> numbers = new SortedSet<int>();


            numbers.Add(5);
            numbers.Add(2);
            numbers.Add(8);
            numbers.Add(3);
            numbers.Add(1);


            //Console.WriteLine("Sorted numbers:");
            //foreach (int number in numbers)
            //{
            //    Console.WriteLine(number);
            //} 

            int maxNumber = numbers.Max;
            int minNumber = numbers.Min;
            //Console.WriteLine($"max number is {maxNumber}");
            //Console.WriteLine($"min number is {minNumber}");    

            // these properties depends on the sorting of the sortedSet(if you reversed the order they will be reversed as well (Like the following example))
            // you can use extesion methods Max(),Min() they will give the correct answer.

            SortedSet<int> RangeNums = numbers.GetViewBetween(1, 8);
            //foreach (var num in RangeNums)
            //{
            //    Console.Write($"{num} ");
            //}
            #endregion
            #region Reversed Order
            SortedSet<int> ReversedNumbers = new SortedSet<int>(new intComparer());


            ReversedNumbers.Add(5);
            ReversedNumbers.Add(2);
            ReversedNumbers.Add(8);
            ReversedNumbers.Add(3);
            ReversedNumbers.Add(1);


            //Console.WriteLine("Sorted numbers in reverse order:");
            //foreach (int number in ReversedNumbers)
            //{
            //    Console.WriteLine(number);
            //} 
            #endregion
            #endregion
            #region User definded data type

            #endregion

            #endregion

        }
    }
}
