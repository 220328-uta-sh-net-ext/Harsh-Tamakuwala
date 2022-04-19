namespace CodingChallenge
{
    public class Pelindrome
    {
        public static bool PelindromeMethod(string s1)
        {
            s1= s1.ToLower().Replace(" ","");
            var tempString=ReverseString(s1.ToLower());
            if(tempString==s1)
                return true;
            else
                return false;

        }

        private static string ReverseString(string s1)
        {
           Console.WriteLine(s1);
            var charArray = s1.ToCharArray();
            var reString="";
           
            for (int i = 0; i < charArray.Length; i++)
            {
               reString+=charArray[charArray.Length-1-i];
            }
          
            
            return reString;
        }
    }

}