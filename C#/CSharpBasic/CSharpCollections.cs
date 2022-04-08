//For Non-Generic
using System.Collections;
using System.Collections.Generic;
//using System.Collections.Generic;
namespace CSharpBasic
{
    public class CSharpCollections
    {
        
        public static void ArrayListCollection(){
            ArrayList EmployeesList = new ArrayList();
            EmployeesList.Add("Harsh");
            EmployeesList.Add("Blake");
            EmployeesList.Add(123);
            // ArrayList emps =new ArrayList(){"Harsh","shark"};
            foreach (var item in EmployeesList)
            {
                Console.WriteLine(item);
            }
        }
    
        public static void GenericList(){
            List<string> employees = new List<string>();
             employees.Add("Harsh");
            employees.Add("Blake");
            employees.Insert(2,"hey");
            Console.WriteLine(employees[0]);
            foreach (var item in employees)
            {
                Console.WriteLine(item);
            }
        }
    
        public static void GenericQueue(){
            Queue<string> name=new Queue<string>();
            name.Enqueue("Harsh");
            name.Enqueue("neel");
            name.Enqueue("smit");
            name.Dequeue();
            Console.WriteLine("First ; "+ name.Peek());
            foreach (var item in name)
            {
                Console.WriteLine(item);
            }
        
        }
    
    
        public static void GenericLinkedList(){
            LinkedList<string> names = new LinkedList<string>();
           names.AddFirst("Harsh");
           names.AddLast("neel");
           var node = names.AddFirst("smit");
            names.AddAfter(node,"milin");      
            foreach (var item in names)
            {
                Console.WriteLine(item);
            }
              }
    }
}