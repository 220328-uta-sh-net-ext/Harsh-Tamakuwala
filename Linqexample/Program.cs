using Linqexample.model;

IList<Student> studentList = new List<Student>() { 
    new Student() { StudentID = 1, StudentName = "John", StandardID =1 },
    new Student() { StudentID = 2, StudentName = "Moin", StandardID =1 },
    new Student() { StudentID = 3, StudentName = "Bill", StandardID =2 },
    new Student() { StudentID = 4, StudentName = "Ram",  StandardID =2 },
    new Student() { StudentID = 5, StudentName = "Ron" } 
};

IList<Standard> standardList = new List<Standard>() { 
    new Standard(){ StandardID = 1, StandardName="Standard 1"},
    new Standard(){ StandardID = 2, StandardName="Standard 2"},
    new Standard(){ StandardID = 3, StandardName="Standard 3"}
};
//Where caluse
var standard = from s in studentList
							  where s.StandardID == 2
							  select s;
System.Console.WriteLine("\n------WHERE-----");
Console.WriteLine("Students who is having standard ID: 2");
						  
foreach(Student std in standard){			
			Console.WriteLine(std.StudentName);
		}


//INNER JOIN
var innerJoin = studentList.Join(// outer sequence 
                      standardList,  // inner sequence 
                      student => student.StandardID,    // outerKeySelector
                      standard => standard.StandardID,  // innerKeySelector
                      (student, standard) => new  // result selector
                                    {
                                        StudentName = student.StudentName,
                                        StandardName = standard.StandardName
                                    });
System.Console.WriteLine("\n------inner Join-----");
foreach (var obj in innerJoin)
		{
			
			Console.WriteLine("{0} - {1}", obj.StudentName, obj.StandardName);
		}

//GROUP JOIN		
var groupJoin = standardList.GroupJoin(studentList,  //inner sequence
                                std => std.StandardID, //outerKeySelector 
                                s => s.StandardID,     //innerKeySelector
                                (std, studentsGroup) => new // resultSelector 
                                {
                                    Students = studentsGroup,
                                    StandarFulldName = std.StandardName
                                });

System.Console.WriteLine("\n------Group Join-----");
foreach (var item in groupJoin)
{ 
    Console.WriteLine(item.StandarFulldName );

    foreach(var stud in item.Students)
        Console.WriteLine(stud.StudentName);
}

var orderByDescendingResult = from s in studentList //Sorts the studentList collection in descending order
                   orderby s.StudentName descending
                   select s;
System.Console.WriteLine("\n------ORDER BY STUDENT NAME DESC-----");
foreach (var std in orderByDescendingResult)
        	Console.WriteLine(std.StudentName);

//sum aggregate function
IList<int> intList = new List<int>() { 10, 30,21, 50,39, 87 };

var total = intList.Sum();
System.Console.WriteLine("\n------sum aggregate function----");
Console.WriteLine("Sum: {0}", total);

var sumOfEvenElements = intList.Sum(i => {
			                    if(i%2 == 0)
				                    return i;
			
			                    return 0;
		                        });

Console.WriteLine("Sum of Even Elements: {0}", sumOfEvenElements );

//MAX
System.Console.WriteLine("\n------max aggregate function----");
var MaxValue = intList.Max();

Console.WriteLine("Max: {0}", MaxValue);

//UNION 
IList<string> strList1 = new List<string>() { "One", "Two", "three", "Four" };
IList<string> strList2 = new List<string>() { "Two", "THREE", "Four", "Five" };

var result = strList1.Union(strList2);
System.Console.WriteLine("\n------UNION----");
foreach(string str in result)
        Console.WriteLine(str);

//except 
IList<string> strListe1 = new List<string>(){"One", "Two", "Three", "Four", "Five" };
IList<string> strListe2 = new List<string>(){"Four", "Five", "Six", "Seven", "Eight"};

var resulte = strListe1.Except(strListe2);
System.Console.WriteLine("\n------EXCEPT----");
foreach(string str in resulte)
        Console.WriteLine(str);
System.Console.WriteLine();