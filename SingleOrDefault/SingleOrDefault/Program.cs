using Org.BouncyCastle.Utilities.Collections;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static SingleOrDefault.AllDelegates;
using static SingleOrDefault.GenericsClass;
using static SingleOrDefault.ImplicitExplicitInterfaceClass;
using static SingleOrDefault.InterviewQuestionClass;
using static SingleOrDefault.MethodHidingClass;
using static SingleOrDefault.OperatorOverloading;
using static SingleOrDefault.PrivateConstractorClass;

namespace SingleOrDefault
{
    public class Program
    {
        private static object a;

        class Employee
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public string Department { get; set; }
        }
        static void Main(string[] args)
        {
            List<Employee> Employeelist = new List<Employee>(){
            new Employee() { Id = 1,Name = "sunny", Department = "technical" },
            new Employee() { Id=2, Name="pinki", Department ="hr"},
            new Employee() { Id=3, Name="tensy", Department ="finance"},
            new Employee() { Id=4, Name="bobby", Department ="technical"},
            new Employee() { Id=5, Name="sweety", Department ="hr"}
            };

            var result = Employeelist.FirstOrDefault(e => e.Department == "hr");
            Console.WriteLine(result.Name);
            var result1 = Employeelist.SingleOrDefault(e => e.Department == "finance");
            Console.WriteLine(result1.Name);
            var result2 = Employeelist.LastOrDefault(e => e.Department == "hr");
            Console.WriteLine(result2.Name);

            Console.WriteLine();

            MyClass myClass = new MyClass();

            Console.WriteLine(MyClass.a);
            Console.WriteLine(myClass.b);
            Console.WriteLine(myClass.Sum(10, 7));
            Console.WriteLine(myClass.Sub(10, 7));
            Console.WriteLine(myClass.Multi(10, 7));
            Console.WriteLine(AbstractClass.Div(70, 7));

            Console.WriteLine();

            ClassXYZ.Demo2();
            ClassXYZ xYZ = new ClassXYZ();
            xYZ.Demo1();
            

            Console.WriteLine();

            DuplicateCharCount duplicateCharCount = new DuplicateCharCount();   
            duplicateCharCount.GetDuplicateCharCount();

            Console.WriteLine();

            ShortingArray shortingArray = new ShortingArray();  
            shortingArray.GetShortingArray();

            Console.WriteLine();

            FindDuplicate findDuplicate  = new FindDuplicate();
            findDuplicate.GetDuplicate();

            Console.WriteLine();

            CharacterCount characterCount = new CharacterCount();
            characterCount.GetCharacterCountfromString();

            Console.WriteLine();

            RemovingDeuplicacy removingDeuplicacy = new RemovingDeuplicacy();
            removingDeuplicacy.RemovingDeuplicacyfromArray();

            Console.WriteLine();

            ReverseString reverseString = new ReverseString();
            reverseString.GetReverseString();

            Console.WriteLine();

            SwapingWithoutThiredVariable swapingWithoutThiredVariable = new SwapingWithoutThiredVariable();
            swapingWithoutThiredVariable.GetSwapingWithoutThiredVariable();

            Console.WriteLine();

            Palindrome palindrome = new Palindrome();
            palindrome.CheckPalindrome();

            Console.WriteLine();

            PrimeOrNot primeOrNot = new PrimeOrNot();
            primeOrNot.CheckPrimeOrNot();

            Console.WriteLine();

            Factorial factorial = new Factorial();
            factorial.GetFactorial();

            Console.WriteLine();

            MergeTwoArray mergeTwoArray = new MergeTwoArray();
            mergeTwoArray.MergingTwoArray();

            Console.WriteLine();

            MaxValueFromArray maxValueFromArray = new MaxValueFromArray();
            maxValueFromArray.FindMaxValueFromArray();

            Console.WriteLine();

            EvenOdd evenOdd = new EvenOdd();    
            evenOdd.CheckEvenOdd();

            Console.WriteLine();

            Console.WriteLine("Generic class calling");

            TestGenericsClass<int> testGenericsClass1 = new TestGenericsClass<int>(12);
            TestGenericsClass<string> testGenericsClass2 = new TestGenericsClass<string>("Satya");

            Console.WriteLine();

            Console.WriteLine("Generic method calling with single parameter");

            TestGenericsMethodClass testGenericsMethodClass = new TestGenericsMethodClass();

            testGenericsMethodClass.TestGenericMethodWithSinglePerameter(123);
            testGenericsMethodClass.TestGenericMethodWithSinglePerameter("Test");

            Console.WriteLine();

            Console.WriteLine("Generic method calling with mutlti parameters");

            testGenericsMethodClass.TestGenericMethodWithMutltiPerameter(123,124);
            testGenericsMethodClass.TestGenericMethodWithMutltiPerameter("Test","Hello");

            Console.WriteLine();

            //Console.WriteLine("We are using singletone class and we are creating instance");
            //SingleTonClass.GetInstance();


            stringCheckingWithCharAndLength stringCheckingWithCharAndLength = new stringCheckingWithCharAndLength();
            stringCheckingWithCharAndLength.stringCheckingWithCharAndLengthMethod();

            Console.WriteLine();

            Console.WriteLine("We are using custom extension method");

            CustomExtensionMethod customExtensionMethod = new CustomExtensionMethod();
            customExtensionMethod.ExtensionMethod();

            Console.WriteLine();

            SecondHighestValue secondHighestValue = new SecondHighestValue();
            secondHighestValue.SecondHihestValuefromArray();

            Console.WriteLine();

            Console.WriteLine("We are using operator loading");

            Ticket ticket1 = new Ticket(15);
            Ticket ticket2 = new Ticket(35);

            Ticket TotalTicket = ticket1 + ticket2;

            Console.WriteLine("We are showing total ticket amount: " + TotalTicket.paybleAmount);

            Console.WriteLine();

            OutRefInKeyword outRefInKeyword = new OutRefInKeyword();
            outRefInKeyword.callingOutRefInKeyword();

            Console.WriteLine();

            Console.WriteLine("We are using Implicit and Explicit interfaces.");

            Console.WriteLine(); 

            ImplicitInterfaceClass implicitInterfaceClass = new ImplicitInterfaceClass();
            implicitInterfaceClass.TestMethod();

            Console.WriteLine();

            ITest exPlicitInterface = new ExplicitInterfaceClass();
            exPlicitInterface.TestMethod();

            Console.WriteLine();

            Console.WriteLine("We are creating fibonacci series.");
            Console.WriteLine();
            FibonacciSeries fibonacciSeries = new FibonacciSeries();
            fibonacciSeries.GetFibonacciSeries();

            Console.WriteLine();
            Console.WriteLine("We are hiding method.");

            // ClassAbc
            ChildClassXyz childClassXyz = new ChildClassXyz();
            childClassXyz.TestMethod();

            Console.WriteLine();
            //Console.WriteLine("We are private constrators.");

            //ConstractorClassC.getInstance();
            Console.WriteLine();
            MutableVsImmutable mutableVsImmutable = new MutableVsImmutable();
            mutableVsImmutable.getMutableVsImmutable();

            Console.ReadLine();
        }
    }
}
