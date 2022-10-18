using System.Globalization;

namespace StringLesson
{
    internal class Program
    {
        static void Main(string[] args)
        {
            EqualsString("qwertyuiop", "qwertyuiop");

            Console.WriteLine(SortString("hello"));
            Console.WriteLine(DublicateCharWithoutIntersect("qwerty","knbhvew"));
            Console.WriteLine(string.Join(" ",AnalyzeString("azsxdcfvghbnjmk34567899")));
            

        }



        static bool EqualsString(string s1, string s2) {
            if (s1 == null && s2 == null) return true;
            if (s1 == null || s2 == null|| s1.Length!=s2.Length) return false;
            for (int i = 0; i < s1.Length; i++)
            {
                if (s1[i] != s2[i]) return false;
                        
            }
            return true;
        
        }

        static Dictionary<string,int> AnalyzeString(string s) {

          
            Dictionary<string, int> result = new Dictionary<string, int>()
            {
                { "digit",0 }, 
                { "letter",0 }, 
                { "symbol",0 }, 
                { "punctuation",0 } 
            };
            if (s==null) return result;
             char[] chars = s.ToArray();
            for (int i = 0; i <s.Length; i++)
            {
                if (char.IsDigit(chars[i])) result["digit"]++;
               if (char.IsLetter(chars[i])) result["letter"]++;
               if (char.IsSymbol(chars[i])) result["symbol"]++;
               if (char.IsPunctuation(chars[i])) result["punctuation"]++;

            }
            return result;
        
        }  

        static string SortString(string str) {
            if (str == null) return "No Good";
            char[] chars = str.ToArray();
            Array.Sort(chars);
            return new string(chars);

        }
        static char[] DublicateChar(string s1, string s2) {
            if (s1 == null || s2 == null) return new char[0];
            char[] chars1 = s1.ToArray();
            char[] chars2 = s2.ToArray();
            char[] result = chars1.Intersect(chars2).ToArray();
            return result;
        }

        static char[] DublicateCharWithoutIntersect(string s1, string s2)
        {
            if (s1 == null || s2 == null) return new char[0];
            char[] chars = s1.ToArray();
            if (s1.Length > s2.Length) return DublicateCharWithoutIntersect(s2, s1);
            List<char> list = new List<char>(s2.ToArray());
            List<char> result = new List<char>();
            for (int i = 0; i <chars.Length; i++)
            {
                if (list.Contains(chars[i])) {
                    result.Add(chars[i]);
                    list.Remove(chars[i]);
                }
            }
            return result.ToArray();
        }

    }
}