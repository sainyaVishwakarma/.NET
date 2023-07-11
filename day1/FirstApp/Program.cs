// See https://aka.ms/new-console-template for more information
using person;
using stud;
Console.WriteLine("Hello, World!");

//dynamic datatypes
var id=200;
var name="sainya";
var ch='s';
var status=false;
var salary=60000.20;
var z=65.25f;
Console.WriteLine("id= "+id);
Console.WriteLine("name= "+name);
Console.WriteLine("ch= "+ch);
Console.WriteLine("salary= "+salary);
Console.WriteLine("status= "+status);
Console.WriteLine("z= "+z);
Console.WriteLine("..........");
//value types
int id1=200;
string name1="sainya";
char ch1='s';
bool status1=false;
double salary1=60000.20;
float z1=65.25f;
Console.WriteLine("id= "+id1);
Console.WriteLine("name= "+name1);
Console.WriteLine("ch= "+ch1);
Console.WriteLine("salary= "+salary1);
Console.WriteLine("status= "+status1);
Console.WriteLine("z= "+z1);

Person p= new Person();
DateTime dt=new DateTime(2000,05,25);
Person p1=new Person(11,"aaa","vvv","514","hk@hjj",dt);

Console.WriteLine(p);
Console.WriteLine(p1);

Console.WriteLine("............");

Student s1=new Student(11,"aaa","vvv","514","hk@hjj",dt,90,"dbda");
Console.WriteLine(s1);