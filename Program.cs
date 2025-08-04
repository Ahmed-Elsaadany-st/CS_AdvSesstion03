using System.Collections;

namespace CS_AdvSesstion03
{
    internal class Program
    {
        static void Main(string[] args)
        {
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
           bool isAdd= StdGradeDict.TryAdd("ahmed", 333);
            Console.WriteLine(isAdd);
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


            // That Version Know that Ahmed and ahmed are the same
            Dictionary<string, int> StdGradeDict02 = new Dictionary<string, int>(new StringEqualityComparer())
              {
                  {"Ahmed", 100 },
                  {"Ali", 99 },
                  {"Nora", 90 },
                  // {"ahmed", 55 } // It will throw an exception if you add this 
              };
            #endregion
        }
    }
}
