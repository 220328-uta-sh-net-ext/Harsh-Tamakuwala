using ArrayExercises;
using System;

//Excercises.Excercise1();
//Excercises.Excercise2();
//Excercises.Excercise3();
//Excercises.Excercise4();
//Excercises.Excercise5();
// Excercises.Excercise7();
//Excercises.Excercise6();
using System.Text;

public class Test
{
    public static string secretWord(int N, string S)
    {
        //this is default OUTPUT. You can change it.
        //string[] result = new String[N];
string result="";
        //write your Logic here:
        //Console.Write(S);
          var charArray = S.ToCharArray();

          //approach1
        // char[] atz={'a','b','c','d','e','f','g','h','i','j','k','l','m','n','o','p','q','r','s','t','u','v','w','x','y','z'};
        // char[] zta={'z','y','x','w','v','u','t','s','r','q','p','o','n','m','l','k','j','i','h','g','f','e','d','c','b','a'};
        // char[] temp =new char[N];
      
        // for (int i = 0; i < atz.Length; i++)
        // {
        //     for (int j = 0; j < charArray.Length; j++)
        //     {
        //         if(charArray[j]==atz[i]){
        //             temp[j]=zta[i];
        //             result[j] = temp[j].ToString();
                    
        //         }
        //     }
            // switch (charArray[i])
            // {
            //     case 'a':
            //         charArray[i] = 'z';
            //         break;
            //     case 'b':
            //         charArray[i] = 'y';
            //         break;
            //     case 'c':
            //         charArray[i] = 'x';
            //         break;
            //     case 'd':
            //         charArray[i] = 'w';
            //         break;
            //     case 'e':
            //         charArray[i] = 'v';
            //         break;
            //     case 'f':
            //         charArray[i] = 'u';
            //         break;
            //     case 'g':
            //         charArray[i] = 't';
            //         break;
            //     case 'h':
            //         charArray[i] = 's';
            //         break;        
            //     case 'i':
            //         charArray[i] = 'r';
            //         break;
            //     case 'j':
            //         charArray[i] = 'q';
            //         break;
            //     case 'k':
            //         charArray[i] = 'p';
            //         break;
            //     case 'l':
            //         charArray[i] = 'o';
            //         break; 
            //     case 'm':
            //         charArray[i] = 'n';
            //         break;
            //     case 'n':
            //         charArray[i] = 'm';
            //         break;
            //     case 'o':
            //         charArray[i] = 'l';
            //         break;
            //     case 'p':
            //         charArray[i] = 'k';
            //         break;
            //     case 'q':
            //         charArray[i] = 'j';
            //         break;
            //     case 'r':
            //         charArray[i] = 'i';
            //         break;
            //     case 's':
            //         charArray[i] = 'h';
            //         break;
            //     case 't':
            //         charArray[i] = 'g';
            //         break; 
            //     case 'u':
            //         charArray[i] = 'f';
            //         break;
            //     case 'v':
            //         charArray[i] = 'e';
            //         break;
            //     case 'w':
            //         charArray[i] = 'd';
            //         break;
            //     case 'x':
            //         charArray[i] = 'c';
            //         break;
            //     case 'y':
            //         charArray[i] = 'b';
            //         break;
            //     case 'z':
            //         charArray[i] = 'a';
            //         break;                                                                  
            // }
            
            //Console.Write(charArray.Length);


       // }
        //approach3:
        char[] atz={'a','b','c','d','e','f','g','h','i','j','k','l','m','n','o','p','q','r','s','t','u','v','w','x','y','z'};
        for (int i = 0; i < charArray.Length; i++)
        {
          int index= Array.IndexOf(atz,charArray[i]);
          charArray[i]=atz[atz.Length-1-index];
          result=charArray[i].ToString();
           
        }
        // foreach (var item in result)
        // {
        //     Console.Write(item);
        // }

        return result;
    }

    public static void Main()
    {
        // INPUT [uncomment & modify if required]
        int N = Convert.ToInt32(Console.ReadLine());
        string S = Console.ReadLine();

        // OUTPUT [uncomment & modify if required]
        var result = secretWord(N, S);
        Console.WriteLine(secretWord(N,S));
    }
}