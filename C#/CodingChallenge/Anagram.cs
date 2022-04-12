namespace CodingChallenge
{
    public class Anagram
    {
        public static bool AnagramMethod(string s1, string s2)
        {
            s1 = StringSort(s1);
            s2 = StringSort(s2);
            
            if (s1.Length != s2.Length)
            {
                return false;
            }
            else
            {
                if (s1 == s2)
                {
                    return true;
                }else{
                    return false;
                }
            }

        }

        private static string StringSort(string s1)
        {
            string temp = "";
            var charArray = s1.ToCharArray();

            for (int i = 0; i < charArray.Length; i++)
            {
                for (int j = i + 1; j < charArray.Length; j++)
                {
                    if (System.Convert.ToInt32(charArray[i]) > System.Convert.ToInt32(charArray[j]))
                    {
                        var tempVar = charArray[i];
                        charArray[i] = charArray[j];
                        charArray[j] = tempVar;
                    }
                }

            }
            temp = new String(charArray);

            return temp;
        }
    }
}