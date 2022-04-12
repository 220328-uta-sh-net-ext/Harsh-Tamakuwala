namespace CodingChallenge
{
    public class Pelindrome
    {
        public static bool PelindromeMethod(string s1)
        {
            s1= s1.ToLower();
            var tempString=ReverseString(s1.ToLower());
            if(tempString==s1)
                return true;
            else
                return false;

        }

        private static string ReverseString(string s1)
        {
            string temp = "";
            var charArray = s1.ToCharArray();
            var reCharArray = new char[s1.Length];
            for (int i = 0; i < charArray.Length; i++)
            {
               reCharArray[i]=charArray[charArray.Length-1-i];
            }
            temp = new String(reCharArray);
            
            return temp;
        }
    }

}