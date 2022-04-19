// See https://aka.ms/new-console-template for more information
using CodingChallenge;

section1:
Console.WriteLine("1. Anagram");
Console.WriteLine("2. Pelindrone");
Console.WriteLine("3. Exit");
Console.WriteLine("Select Number: ");
var selectNum =Console.ReadLine();
// int n =0;
//  while(int.TryParse(selectNum,out n)!=true){
//      Console.WriteLine("Not a number. Please select a number: ");
//      selectNum=Console.ReadLine();
//  }

switch(selectNum){
    case "1":
        Console.WriteLine("Enter first string to check anagram: ");
        var s1=Console.ReadLine();

        Console.WriteLine("Enter second string to check anagram: ");
        var s2=Console.ReadLine();
        var result=Anagram.AnagramMethod(s1,s2);
        Console.Write(result);
        Console.WriteLine("\nDo you want to Continue(y/n): ");
        var wantContinueAna=Console.ReadLine().ToLower();
        if(wantContinueAna=="y" || wantContinueAna=="yes"){
            goto section1;
        }else{
            break;
        }
       
    case "2":
        Console.WriteLine("Enter string to check pelindrone: ");
        var s3=Console.ReadLine();

        var resultPelindrome=Pelindrome.PelindromeMethod(s3);
        Console.Write(resultPelindrome);
        Console.WriteLine("\nDo you want to Continue(y/n): ");
        var wantContinuePali=Console.ReadLine().ToLower();
        if(wantContinuePali=="y" || wantContinuePali=="yes"){
            goto section1;
        }else{
            break;
        }
    case "3":
        break;
    default:
        Console.WriteLine("\nSelected number is not from Menu,Please select number from menu.\n");
        goto section1;
}



