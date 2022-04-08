namespace ArrayExercises
{
    public class Excercises
    {
        public static void readArray(int[] a)
        {
            foreach (var item in a)
            {
                Console.Write(item + " ");
            }
        }
        public static void Excercise1()
        {
            int[] ex1 = new int[10];
            for (int i = 0; i < 10; i++)
            {
                Console.Write("element - {0} : ", i);
                ex1[i] = Convert.ToInt32(Console.ReadLine());
            }
            readArray(ex1);

        }

        public static void Excercise2()
        {
            Console.Write("Input the number of elements to store in the array : ");
            int x = Convert.ToInt32(Console.ReadLine());
           
            int[] ex2 = new int[x];
            for (int i = 0; i < x; i++)
            {
                Console.Write("element - {0} : ", i);
                ex2[i] = Convert.ToInt32(Console.ReadLine());
            }
            Array.Reverse(ex2);
            readArray(ex2);

        }
    
        public static void Excercise3()
        {
            Console.Write("Input the number of elements to store in the array : ");
            int x = Convert.ToInt32(Console.ReadLine());
           
            int[] ex3 = new int[x];
            int sum = 0; 
            for (int i = 0; i < x; i++)
            {
                Console.Write("element - {0} : ", i);
                ex3[i] = Convert.ToInt32(Console.ReadLine());
                sum += ex3[i];
            }
            Console.WriteLine("Sum of all elements stored in the array is : "+ sum);
           

        }

         public static void Excercise4()
        {
            Console.Write("Input the number of elements to store in the array : ");
            int x = Convert.ToInt32(Console.ReadLine());
           
            int[] ex4 = new int[x];
            int[] temp = new int[x];
           
            for (int i = 0; i < x; i++)
            {
                Console.Write("element - {0} : ", i);
                temp[i] = Convert.ToInt32(Console.ReadLine());
                 ex4[i] = temp[i];
               
            }
           Console.WriteLine("The elements stored in the first array are :");
            readArray(temp);
            Console.WriteLine();
            Console.WriteLine("The elements copied into the second array are :");
           readArray(ex4);

        }

    }
}