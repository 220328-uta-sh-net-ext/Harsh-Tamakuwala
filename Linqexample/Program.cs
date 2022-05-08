using Linqexample.model;

IList<Student> studentList = new List<Student>() { 
    new Student() { StudentID = 1, StudentName = "John", StandardID =1,Age = 18  },
    new Student() { StudentID = 2, StudentName = "Moin", StandardID =1 ,Age = 20 },
    new Student() { StudentID = 3, StudentName = "Bill", StandardID =2 ,Age = 25 },
    new Student() { StudentID = 4, StudentName = "Ram",  StandardID =2 ,Age = 19 },
    new Student() { StudentID = 5, StudentName = "Ron" } 
};

IList<Standard> standardList = new List<Standard>() { 
    new Standard(){ StandardID = 1, StandardName="Standard 1"},
    new Standard(){ StandardID = 2, StandardName="Standard 2"},
    new Standard(){ StandardID = 3, StandardName="Standard 3"}
};
// checks whether all the students are teenagers    
bool areAllStudentsTeenAger = studentList.All(s => s.Age > 12 && s.Age < 20);
System.Console.WriteLine("----ALL----");
System.Console.WriteLine("checks whether all the students are teenagers");
Console.WriteLine(areAllStudentsTeenAger);


// checks whether any the students are teenagers  
bool isAnyStudentTeenAger = studentList.Any(s => s.Age > 12 && s.Age < 20);
System.Console.WriteLine("\n----ANY----");
System.Console.WriteLine("checks whether any the students are teenagers");
Console.WriteLine(isAnyStudentTeenAger);

//Check whether student list contains the specific student or not return bool
Student std = new Student(){ StudentID =3, StudentName = "Bill"};
bool result = studentList.Contains(std);
System.Console.WriteLine("\n----Contain----");
System.Console.WriteLine("Check whether student list contains the specific student or not");
Console.WriteLine(result);


//Avarage Aggregate funtion
var avgAge = studentList.Average(s => s.Age);
System.Console.WriteLine("\n----Avarage Aggregate funtion----");
Console.WriteLine("Average Age of Student: {0}", avgAge);


//Count Aggregate Function
Console.WriteLine("\n----Count Aggregate funtion----");
var totalStudents = studentList.Count();
Console.WriteLine("Total Students: {0}", totalStudents);

var adultStudents = studentList.Count(s => s.Age >= 18);
Console.WriteLine("Number of Adult Students: {0}", adultStudents );

//MAX
Console.WriteLine("\n------max aggregate function----");
var oldest = studentList.Max(s => s.Age);

Console.WriteLine("Oldest Student Age: {0}", oldest);

//sum aggregate function
Console.WriteLine("\n------sum aggregate function----");
var sumOfAge = studentList.Sum(s => s.Age);

Console.WriteLine("Sum of all student's age: {0}", sumOfAge);
		
var numOfAdults = studentList.Sum(s => {
			
	if(s.Age >= 18)
	    return 1;
	else
	    return 0;
});
 
Console.WriteLine("Total Adult Students: {0}", numOfAdults);



IList<int> intList = new List<int>() { 10, 21,};
IList<string> strList = new List<string>() { "One", "Two" };
IList<int> intDeList = new List<int>() {};

//Element at, ElementAtOrDefault()  
Console.WriteLine("\n------Elementat, ElementAtOrDefault----");
Console.WriteLine("1st Element in intList: {0}", intList.ElementAt(0));
Console.WriteLine("1st Element in strList: {0}", strList.ElementAt(0));

Console.WriteLine("3rd Element in intList: {0}", intList.ElementAtOrDefault(2));
Console.WriteLine("3rd Element in strList: {0}", strList.ElementAtOrDefault(2));

// First & FirstOrDefault 
Console.WriteLine("\n------First & FirstOrDefault----");
Console.WriteLine("1st Element in intList: {0}", intList.First());

Console.WriteLine("1st Element in intDeList: {0}", intDeList.FirstOrDefault());

//Last & LastOrDefault
Console.WriteLine("\n------Last & LastOrDefault----");
Console.WriteLine("Last Element in intList: {0}", intList.Last());
Console.WriteLine("last Element in intDeList: {0}", intDeList.LastOrDefault());