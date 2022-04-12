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
            Console.WriteLine("Sum of all elements stored in the array is : " + sum);


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

        public static void Excercise5()
        {
            Console.Write("Input the number of elements to store in the array : ");
            int x = Convert.ToInt32(Console.ReadLine());
            int[] ex5 = new int[x];
            int cnt = 0;
            int[] temp = new int[x];
            for (int i = 0; i < x; i++)
            {
                Console.Write("element - {0} :", i);
                ex5[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i < ex5.Length; i++)
            {
                for (int j = i; j < ex5.Length - 1; j++)
                {

                    if ((temp[i] != ex5[j]) && (ex5[j] == ex5[j + 1]))
                    {
                        temp[i] = ex5[j];
                        cnt++;
                        break;
                    }
                }
            }
            Console.WriteLine("Total number of duplicate elements found in the array is : " + cnt);
        }

        public static void Excercise6() {
         for (int i = 0; i < 26; i++)
         for (char alphabet = 'a'; alphabet <= 'z'; alphabet++)
            {
                Console.Write(alphabet + " - ");
            }

         }

        public static void Excercise7()
        {
            Console.Write("Input the number of elements to store in the array : ");
            int x = Convert.ToInt32(Console.ReadLine());
            int[] ex71 = new int[x];

            for (int i = 0; i < x; i++)
            {
                Console.Write("element - {0} :", i);
                ex71[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.Write("Input the number of elements to store in the array : ");
            int y = Convert.ToInt32(Console.ReadLine());
            int[] ex72 = new int[y];
            for (int i = 0; i < y; i++)
            {
                Console.Write("element - {0} :", i);
                ex72[i] = Convert.ToInt32(Console.ReadLine());
            }
            int[] temp = new int[x + y];
            if (x == y)
            {
                for (int i = 0; i < x; i++)
                {
                    temp[i] = ex71[i];

                }
                for (int i = y; i < temp.Length; i++)
                {
                    temp[i] = (ex72[i - y]);
                }
                Array.Sort(temp);
                for (int i = 0; i < temp.Length; i++)
                {
                    Console.Write(temp[i] + " ");
                }

            }
            else
            {
                Console.WriteLine("Arrays are not same size!!!");
            }
        }


        public static void Excercise8()
        {
             Console.Write("Input the number of elements to store in the array : ");
            int x = Convert.ToInt32(Console.ReadLine());
            int[] ex8 = new int[x];

            for (int i = 0; i < x; i++)
            {
                Console.Write("element - {0} :",i);
                ex8[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Frequency of all elements of array :");

            for (int i = 0; i < ex8.Length; i++)
            {
                int cnt=1;
               int fr =-1;
                for (int j = i+1; j < ex8.Length; j++)
                {

                    if(ex8[i]==ex8[j]){
                        cnt++;
                        fr =cnt;
                    }
                   // fr--;
                }
               // if(fr!=-1)
                Console.WriteLine(ex8[i]+" occurs "+ cnt+ fr);

            }
            // int[] arr1 = new int[100];
            // int[] fr1 = new int[100];
            // int n, i, j, ctr;


            // Console.Write("\n\nCount the frequency of each element of an array:\n");
            // Console.Write("----------------------------------------------------\n");

            // Console.Write("Input the number of elements to be stored in the array :");
            // n = Convert.ToInt32(Console.ReadLine());

            // Console.Write("Input {0} elements in the array :\n", n);
            // for (i = 0; i < n; i++)
            // {
            //     Console.Write("element - {0} : ", i);
            //     arr1[i] = Convert.ToInt32(Console.ReadLine());
            //     fr1[i] = -1;
            // }
            // for (i = 0; i < n; i++)
            // {
            //     ctr = 1;
            //     for (j = i + 1; j < n; j++)
            //     {
            //         if (arr1[i] == arr1[j])
            //         {
            //             ctr++;
            //             fr1[j] = 0;
            //         }
            //     }

            //     if (fr1[i] != 0)
            //     {
            //         fr1[i] = ctr;
            //     }
            // }
            // for (i = 0; i < n; i++)
            // {
                
            //         Console.Write( fr1[i]);
                
            // }
            // Console.Write("\nThe frequency of all elements of the array : \n");
            // for (i = 0; i < n; i++)
            // {
            //     if (fr1[i] != 0)
            //     {
            //         Console.Write("{0} occurs {1} times\n", arr1[i], fr1[i]);
            //     }
            // }
        }
    }
}