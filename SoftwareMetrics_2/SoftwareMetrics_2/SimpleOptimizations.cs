using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareMetrics_2
{
    public class SimpleOptimizations
    {
        bool IsEmptyString(string input)
        {
            return input == "";
        }

        bool IsEmptyString_Optimized(string input)
        {
            return input == string.Empty;
        }

        bool IsNullOrEmptyString(string input)
        {
            return input == null || input == "";
        }

        bool IsNullOrEmptyString_Optimized(string input)
        {
            return string.IsNullOrEmpty(input);
        }

        bool Equals(string inputA, string inputB)
        {
            return string.Equals(inputA, inputB);
        }

        bool Equals_RemoveWhiteSpace(string inputA, string inputB)
        {
            return string.Equals(inputA.Trim(), inputB.Trim());
        }

        public static string ArrayToString(string[] arr, string delimiter)
        {
            string result = string.Empty;

            for (int i = 0; i < arr.Length; i++)
            {
                result += arr[i];
                if (i != arr.Length - 1)
                {
                    result += delimiter;
                }
            }

            return result;
        }

        public static string ArrayToString_Optimized(string[] arr, string delimiter)
        {
            return string.Join(delimiter, arr);
        }

        public static string[] SplitBySymbol(string input, string delimiter)
        {
            //"asd,b,c,d"
            List<string> symbols = new List<string>();
            string tempValue = string.Empty;
            foreach (char symbol in input)
            {
                if (symbol.ToString() == delimiter)
                {
                    symbols.Add(tempValue);
                    tempValue = string.Empty;
                }
                else
                {
                    tempValue += symbol.ToString();
                }
            }
            if (tempValue != string.Empty)
            {
                symbols.Add(tempValue);
            }

            return symbols.ToArray();
        }

        public static string[] SplitBySymbol_Optimized(string input, string delimiter)
        {
            return input.Split(new string[] { delimiter }, StringSplitOptions.None);
        }

        void EmptyList(List<object> list)
        {
            for (int i = 0; i < list.Count; i++)
            {
                list.RemoveAt(i);
            }
        }

        void EmptyList_Optimized(List<object> list)
        {
            list.Clear();
        }

        void UsingExample()
        {
            using (FileStream fs = new FileStream("ReadMe.txt", FileMode.Open))
            {
                //fs.Read()...
                //Do other work
            }
        }

        public static void DoWork(int action)
        {
            switch (action)
            {
                case 1:
                    {
                        Console.WriteLine("Add");
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine("Update");
                        break;
                    }
                case 3:
                    {
                        Console.WriteLine("Remove");
                        break;
                    }
                case 4:
                    {
                        Console.WriteLine("Select");
                        break;
                    }
                case 5:
                    {
                        Console.WriteLine("Undo");
                        break;
                    }
                case 6:
                    {
                        Console.WriteLine("Redo");
                        break;
                    }
                case 0:
                default:
                    {
                        Console.WriteLine("Exit");
                        break;
                    }
            }
        }

        public static void DoWork_Optimized(int action)
        {
            ActionTypes defaultAction = (ActionTypes)action;
            switch (defaultAction)
            {
                case ActionTypes.Add:
                    {
                        Console.WriteLine("Add");
                        break;
                    }
                case ActionTypes.Update:
                    {
                        Console.WriteLine("Update");
                        break;
                    }
                case ActionTypes.Remove:
                    {
                        Console.WriteLine("Remove");
                        break;
                    }
                case ActionTypes.Select:
                    {
                        Console.WriteLine("Select");
                        break;
                    }
                case ActionTypes.Undo:
                    {
                        Console.WriteLine("Undo");
                        break;
                    }
                case ActionTypes.Redo:
                    {
                        Console.WriteLine("Redo");
                        break;
                    }
                case ActionTypes.Exit:
                default:
                    {
                        Console.WriteLine("Exit");
                        break;
                    }
            }
        }

        void NullCoalescingOperator(string input)
        {
            string defaultValue = "Default";
            if (input == null)
            {
                input = defaultValue;
            }
            Console.WriteLine(input);
        }

        void NullCoalescingOperator_Optimized(string input)
        {
            string defaultValue = "Default";
            string result = input != null ? input : defaultValue;
            Console.WriteLine(input);
        }

        void NullCoalescingOperator_Optimized2(string input)
        {
            string defaultValue = "Default";
            string result = input ?? defaultValue;
            Console.WriteLine(input);
        }

        public static void NullCoalescingOperator_Person_Optimized2(Person person)
        {
            Person defaultValue = new Person() { Name = "John Doe", Age = 25, DoB = new DateTime(1993, 2, 15) };
            Person result = person ?? defaultValue;
            Console.WriteLine(result);
        }

        /// <summary>
        /// Method to find a value in dictionary by given key
        /// </summary>
        /// <param name="keyValuePairs">The dictionary with data.</param>
        /// <param name="key">The key which should be found...</param>
        /// <returns>Returns <c>string</c></returns>
        /// <exception cref="ArgumentNullException"><paramref name="key"/> can't be null.</exception>
        string FindValueByKey(Dictionary<int, string> keyValuePairs, int? key)
        {
            if (key == null)
            {
                throw new ArgumentNullException("key", "Key can't be null");
            }
            foreach (KeyValuePair<int, string> keyValue in keyValuePairs)
            {
                if (keyValue.Key == key)
                {
                    return keyValue.Value;
                }
            }
            return null;
        }

        string FindValueByKey_Optimized(Dictionary<int, string> keyValuePairs, int key)
        {
            string value = null;
            keyValuePairs.TryGetValue(key, out value);
            return value;
        }

        string FindValueByKey_Optimized_Safety(Dictionary<int, string> keyValuePairs, int key)
        {
            if (keyValuePairs.ContainsKey(key))
            {
                return keyValuePairs[key];
            }
            return null;
        }

        public static int? GetKeyInArray(List<int> data, int key)
        {
            foreach (int dataElement in data)
            {
                if (dataElement == key)
                {
                    return dataElement;
                }
            }
            return null;
        }

        int? GetKeyInArray_Optimized(List<int> data, int key)
        {
            return data.FirstOrDefault(i => i == key);
        }

        bool CompareStringsNoCase(string inputA, string inputB)
        {
            //"abc"
            //"abC"
            //"ABC"
            return inputA.ToUpper() == inputB.ToUpper();
        }

        bool CompareStringsNoCase_Optimized(string inputA, string inputB)
        {
            //"abc"
            //"abC"
            //"ABC"
            return inputA.Equals(inputB, StringComparison.CurrentCultureIgnoreCase);
        }

        Person GetPersonByName(List<Person> people, string personName)
        {
            foreach (Person person in people)
            {
                if (person.Name == personName)
                {
                    return person;
                }
            }
            return null;
        }

        Person GetPersonByName_Optimized(List<Person> people, string personName)
        {
            return people.FirstOrDefault(person =>
                person.Name.Equals(personName, StringComparison.CurrentCultureIgnoreCase)
            );
        }

        List<Person> GetOlderThan(List<Person> people, int age)
        {
            List<Person> result = new List<Person>();
            foreach (Person person in people)
            {
                if (person.Age > age)
                {
                    result.Add(person);
                }
            }
            return result;
        }

        List<Person> GetOlderThan_Optimized(List<Person> people, int age)
        {
            return people.Where(person => person.Age > age).ToList();
        }

        void NullableTypes()
        {
            //null = not exist in DB;
            //false = deactived;
            //true = still active;
            bool? active = null;
            if (active == true)
            {
                //
            }

            if (active != true)
            {
                //
            }

            if (active.GetValueOrDefault())
            {

            }

            int? age = null;
            if (age.GetValueOrDefault(int.MaxValue) != int.MaxValue)
            {
                //
            }
        }
    }
}
