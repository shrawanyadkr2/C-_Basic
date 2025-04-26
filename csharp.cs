
// Console.WriteLine("Hello, World! welcome");
// using System; // the namespace declaration 
// namespace is the collection of the clas
// A nemespace is used 
// using System;

/*
class program{
    static void Main(){
        System.Console.WriteLine("hello bhai c# training");
        Main1();
    }

    static void Main1(){
        System.Console.WriteLine("hello bhai c# training !hs");
    }
}
*/



/*


using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Please enter your name:");
        string firstName = Console.ReadLine();
        // Console.WriteLine("Hello " + userName);


        Console.WriteLine("Plse enter the last Name");
        string lastName = Console.ReadLine();


        Console.WriteLine("hello {0} {1}",firstName,lastName);

    }
}


*/

/*
boolean --------> true & false
Integer ----------> sbyte,byte,short,unshort,int,uint,long,ulong,char
Floating ----> float and double
Decimal ---->
String  ----->


*/



/*
using System;

class Program
{
    static void Main()
    {

        int i = 0;
        Console.WriteLine("int has {0}", int.MinValue);
        Console.WriteLine("int has {0}", float.MinValue);

        Console.WriteLine("double has {0}", double.MinValue);

        Console.WriteLine("decimal has {0}", decimal.MinValue);

        Console.WriteLine("long {0}", long.MinValue);

    }
}

*/



/*
using System;

class Program{
    static void Main(){
        // go throgh the escape sequence

        string Name = "\"Shrawan\"";
        string name = "one\ntwo\nthree";
        Console.WriteLine(name);
        Console.WriteLine(Name);

        string folder=@"c:\shrawan\dotnet\training\cshrap";
        Console.WriteLine(folder);

    }
}

*/


/*Operator*/

/*
using System;

class Program{
    static void Main(){
        int i=10;

        bool isNumber = i == 10 ? true : false;
        Console.WriteLine(isNumber);
        bool b=true;
        Console.WriteLine(i);

        int num= 10;
        if(num==10){
            Console.WriteLine("true");
        }
        if(num==10 && b==true){
            Console.WriteLine("shi hai {0} ",num);
        }
    }
}


*/

/*

using System;

class Major
{
    static void Main()
    {
        bool? areYouMajor=null;

        if (areYouMajor == true)
        {
            Console.WriteLine("user is major");

        }
        else if (areYouMajor == false)
        {
            Console.WriteLine("user is not major");
        }
        else
        {
            Console.WriteLine("no answer");
        }
    }
}
*/

/*
 using System;
 class Program{
    static void Main(){
        int ? TicketOnSale = 100;
        int AvailableTicket;

        if(TicketOnSale == null){
            AvailableTicket=0;
        }
        else{
            AvailableTicket=(int)TicketOnSale;

        }
         Console.WriteLine("AvailableTickets={0}",AvailableTicket);
    }
 }
*/


/*
 using System;
 class Program{
    static void Main(){
        int ? TicketOnSale = null;
        int AvailableTicket = TicketOnSale ?? 0;

       
         Console.WriteLine("AvailableTickets={0}",AvailableTicket);
    }
 }

 */


/*


using System;
class Program
{
    static void Main()
    {
        float f=123.45F;
        int i = (int)f;

        float g=123323323322322332.45F;
        int h=Convert.ToInt32(g);
        Console.WriteLine(i);

    }

}

*/

/*
using System;
class Program
{
    static void Main()
    {
       int i = 100;
       float f = i;

       Console.WriteLine(f);
    }

}

*/

/*


using System;
class Program
{
    static void Main()
    {
       string strNumber="100";
       int i = int.Parse(strNumber);

       Console.WriteLine(i);
    }

}


*/



/*



using System;

class Program{
    static void Main(){
        string strNumber="100TB";
        int Result=0;
        bool isConversionDone = int.TryParse(strNumber,out Result);

        if(isConversionDone){
            Console.WriteLine(Result);
        }
        else{
            Console.WriteLine("plse enter a valid number");
        }
    }
}

*/

/*
using System;

class Program{
    static void Main(){
    //    int i = 10;
        int[] arr=new int[3];

        arr[0]=0;
        arr[1]=1;
        arr[2]=92;

        Console.WriteLine(arr[2]);

    }
}

*/



/*
using System;

class Program{
    static void Main(){
        // Console.WriteLine("hello");
        string City = "London";
        if(City == "London"){
            Console.WriteLine("");
        }
    }
}

*/



/*


/// <summary>
/// this is a sample class and sample 
/// </summary>
public class SampleClass{

}


*/



/*


using System;

class Program {
    static void Main() {
        Console.WriteLine("Please enter a number:");

        string input = Console.ReadLine();
        if (int.TryParse(input, out int userNumber)) {
            if (userNumber == 1) {
                Console.WriteLine("Your number is one.");
            } else {
                Console.WriteLine("Your number is not one.");
            }
        } else {
            Console.WriteLine("Invalid input. Please enter a valid number.");
        }
    }
}


*/

/*


using System;

class Program {
    static void Main() {
        Console.WriteLine("Enter the number:");

        int userNumber = int.Parse(Console.ReadLine());

        switch (userNumber) {
            case 10:
                Console.WriteLine("10");
                break;
            case 20:
                Console.WriteLine("20");
                break;
            case 30:
                Console.WriteLine("30");
                break;
            default:
                Console.WriteLine("Your number is not 10, 20, or 30.");
                break;
        }
    }
}

*/

/*
using System;

class Program {
    static void Main() {
        Console.WriteLine("Enter the number:");

        int userNumber = int.Parse(Console.ReadLine());

        switch (userNumber) {
            case 10:
            case 20:
            case 30:
                Console.WriteLine("your number is {0}",userNumber);
                break;
            default:
                Console.WriteLine("Your number is not 10, 20, or 30.");
                break;
        }
    }
}

*/

/*



using System;
using System.Runtime.CompilerServices;
class Program{

    static void Main(){

        int TotalCoffeeCost = 0;

        start:
        
        Console.WriteLine("1- small, 2-Medium, 3-Large");
        int userchoise = int.Parse(Console.ReadLine());


        switch (userchoise) {
            case 1:
                TotalCoffeeCost+=1;
                break;
            case 2:
                TotalCoffeeCost+=2;
                break;
            case 3:
               TotalCoffeeCost+=2;
                break;
            default:
                Console.WriteLine("invalid choise");
                break;
        }

        Decide:
        Console.WriteLine("Do you want to buy another coffee = yes & No");
        string userDecision = Console.ReadLine();

        switch(userDecision.ToUpper()){
            case "YES":
                goto start;
            case "NO":
                break;
            default:
                Console.WriteLine("your choise {0} is invalid. please try again...");
                goto Decide;
        }


        Console.WriteLine("thank u for shopping with us");
        Console.WriteLine("bill amount ={0}",TotalCoffeeCost);

    }

}



*/


/*


using System;
class Program{
    static void Main(){
        Console.WriteLine("plse enter the the destination:-");
        int userTarget = int.Parse(Console.ReadLine());

        int start = 0;

        while(start <= userTarget){
            Console.WriteLine(start);
            //print in the same line
            Console.Write(start + " ");
            start=start+2;

        }

    }
}

*/

/*

using System;

class Program {
    static void Main() {
        Console.WriteLine("Please enter your target:");
        int userTarget = int.Parse(Console.ReadLine());

        int start = 0;

        while (start <= userTarget) {
            Console.Write(start + " ");
            start = start + 2;
        }

        string userChoice;  // declare the variable before use

        do {
            Console.WriteLine("\nDo you want to continue - Yes or No?");
            userChoice = Console.ReadLine().ToUpper();  // convert to uppercase for easy checking

            if (userChoice != "YES" && userChoice != "NO") {
                Console.WriteLine("Invalid choice, please say Yes or No.");
            }

        } while (userChoice != "YES" && userChoice != "NO");

        if (userChoice == "YES") {
            Console.WriteLine("You chose to continue.");
            // You can restart or do something else here if you want
        } else {
            Console.WriteLine("Program ended.");
        }
    }
}

*/

/*

using System;

class Program{
    static void Main(){
        int[] Number = new int[3];
        Number[0]=101;
        Number[1]=102;
        Number[2]=103;

        for(int i=0;i<Number.Length;i++){
            Console.WriteLine(Number[i]);
        }

        int j=0;
        while(j<Number.Length){
            Console.WriteLine(Number[j]);
            j++;
        }


        // for-each loo[p]
        foreach(int k in Number){
            Console.WriteLine(k);
        }
    }
}


*/




/*


using System;

class Program{
    static void Main(){
        for(int i=1; i<=20 ; i++){
            Console.WriteLine(i);
            if(i==10) break;
        }
    }
}


*/

/*


using System;

class Program{
    static void Main(){
        for(int i=1; i<=20 ; i++){
            //skip the odd number
            if(i%2==1)
                continue;
            Console.WriteLine(i);
        }
    }
}


*/


/*



using System;

class Program
{
    // static method 
    public static void Main()
    {
        Program p = new Program();
        p.EvenNumberFun();
    }
    //instance method 
    public void EvenNumberFun()
    {
        int start = 0;
        while (start <= 20)
        {
            Console.WriteLine(start);
            start = start + 2;
        }
    }
}

*/

/*


using System;

class Program
{
    // static method 
    public static void Main()
    {
       Program.EvenNumberFun();
    }
    //instance method 
    public static void EvenNumberFun()
    {
        int start = 0;
        while (start <= 20)
        {
            Console.WriteLine(start);
            start = start + 2;
        }
    }
}


*/



/*

using System;

class Program
{
    // static method 
    public static void Main()
    {
       Program.EvenNumberFun(30);

       Program p= new Program();

       int sum=p.Add(10,20);

       Console.WriteLine("sum is equal to {0}",sum);
    }
    //instance method 

    public int Add(int FN, int SN){
        return FN + SN;
    }


    public static void EvenNumberFun(int target)
    {
        int start = 0;
        while (start <= target)
        {
            Console.WriteLine(start);
            start = start + 2;
        }
    }
}


*/


/*
using System;

class Program
{
    public static void Main()
    {
        int i=0;
        simpleMethod(i);

        Console.WriteLine(i);
    }

    public static void simpleMethod(int j)
    {
        j=101;
    }
}

*/

/*


using System;
class Program{
    public static void Main(){
        int i=0;

        simpleMethod(ref i);

        Console.WriteLine(i);
        
    }

    public static void simpleMethod(ref int j){
        j=1001;
    }
}


*/


/*


using System;
class Program
{
    public static void Main()
    {
        int total = 0;
        int product = 0;

        calculate(10, 20, out total, out product);

        Console.WriteLine("sum = {0} && product = {1}",total,product);

    }

    public static void calculate(int fn, int sn, out int sum, out int product)
    {
        sum = fn + sn;
        product = fn * sn;
    }

}


*/


/*


using System;
class Program
{
    public static void Main()
    {
        
        int[] Numbers = new int[3];

        paramsMethod();
        paramsMethod(Numbers);
        paramsMethod(12,3,2);


    }


    public static void paramsMethod(params int[] Numbers)
    {

        Console.WriteLine("there are {0} element", Numbers.Length);

        foreach (int i in Numbers)
        {
            Console.WriteLine(i);
        }
    }
}


*/



/*



using System;
using PATA=ProjectA.TeamA;
using PATB=ProjectA.TeamB;

using System.Collections;
using System.Configuration;
class Program{
    public static void Main(){
        PATA.ClassA.Print();
        PATB.ClassA.Print();

    }
}

namespace ProjectA{
    namespace TeamA{
        class ClassA{
            public static void Print(){
                Console.WriteLine("Team A print Method");
            }
        }
    }
}

namespace ProjectA{
    namespace TeamB{
        class ClassA{
            public static void Print(){
                Console.WriteLine("Team B print Method");
            }
        }
    }
}



*/



/*


using System;
using PATA = ProjectA.TeamA;
using PATB = ProjectA.TeamB;

using System.Collections;
using System.Configuration;
class Program
{
    public static void Main()
    {

    }
}

namespace ProjectA
{
    namespace TeamA
    {
        class ClassA
        {
            public static void Print()
            {
                Console.WriteLine("Team A print Method");
            }
        }
    }
}

namespace ProjectA
{
    namespace TeamB
    {
        class ClassA
        {
            public static void Print()
            {
                Console.WriteLine("Team B print Method");
            }
        }
    }
}

*/


// namespace is remain to understand


/*

using System;

class Customer
{
    string _firstName;
    string _lastName;

    // Default constructor, chaining to parameterized constructor
    public Customer() : this("No first name provided", "No last name provided")
    {
    }

    // Parameterized constructor
    public Customer(string firstName, string lastName)
    {
        this._firstName = firstName;
        this._lastName = lastName;
    }

    public void PrintFullName()
    {
        Console.WriteLine("Full Name is: {0} {1}", this._firstName, this._lastName);
    }

    // Destructor
    ~Customer()
    {
        // Clean up code
    }
}

class Program
{
    public static void Main()
    {
        Customer c1 = new Customer();
        c1.PrintFullName();


        Customer c2 = new Customer("hsra","jhs");
    }
}


*/


/**/


// static and instance class

using System;

class Circle {
    float _PI = 3.141F;
    int _Radius;

    public Circle(int Radius) {
        this._Radius = Radius;
    }

    public float calculateArea() {
        return this._PI * this._Radius * this._Radius;
    }
}

class Program {
    static void Main() {
        Circle c1 = new Circle(6);
        float area = c1.calculateArea();  // calculate the area
        Console.WriteLine("Area of Circle is: " + area);  // print the area
    }
}
