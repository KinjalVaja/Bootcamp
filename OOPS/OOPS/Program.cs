using System;


namespace OOPS
{
    // Different Definitions of Class:
    // 1) Class and Object are the basic concepts of Object-Oriented Programming which revolve around the real-life entities.
    // 2) A class is a user-defined reference blueprint or prototype from which objects are created. OR User define reference data type is a class.
    // 3) Basically, a class combines the fields and methods(member function which defines actions) into a single unit. OR a class combines the fields and subroutines(actions) into a single unit.
    // 4) In C#, classes support encapsulation, polymorphism, inheritance, abstraction and also provide the concept of derived classes and base classes.


    // Demo 1 | Class & Object In Deep - Stack & Heap Memory Locations - Difefrence between class & struct as well as reference type & value type.
    class ClassObjectDeepDemo
    {
        // Without public modifier int a cannot be accessible as by default all the fields and sub routines are private in class.
        public int a;
    }

    // Demo 1 | Struct & Reference In Deep - Stack & Heap Memory Locations - Difefrence between class & struct as well as reference type & value type.
    struct StructureReferenceDeepDemo {
        public int a;
    }

    //Demo 2 | Encapsulation & Access Modifiers - Private, Protected, Internal, ProtectedInternal, Public.
    // Encapsulation is defined 'as the process of enclosing one or more items within a physical or logical package'.
    // Encapsulation, in object oriented programming methodology, prevents access to implementation details.
    // Encapsulation is implemented by using access specifiers. An access specifier defines the scope and visibility of a class member.

    // 1) Public Access Specifier: Public access specifier allows a class to expose its member variables and member functions to other functions and objects.Any public member can be accessed from outside the class.
    // 2) Private Access Specifier: Allows a class to hide its member variables and member functions from other functions and objects. Only functions of the same class can access its private members.
    // 3) Protected Access Specifier: Protected access specifier allows a child class to access the member variables and member functions of its base class.
    // 4) Internal Access Specifier: Internal access specifier allows a class to expose its member variables and member functions to other functions and objects in the current assembly. In other words, any member with internal access specifier can be accessed from any class or method defined within the application in which the member is defined.
    // 5) ProtectedInternal Access Specifier: The protected internal access specifier allows a class to hide its member variables and member functions from other class objects and functions, except a child class within the same application.This is also used while implementing inheritance.
    // 6) PrivateProtected Access Specifier: It is used to specifies that access is limited to the containing class or types derived from the containing class within the current assembly.

    // By default all class are internal in same namespace.
    // By default all the fiels and subroutines are private in class.

    // Here i declare Encapsulation class as public because without public specifier we cant inherit class in seprate namespace.
    // We check the same by removing public keyword from the class declaration - IT FIRES BUG.
    public class Encapsulation {
        private int pr; // By default all the fields of class are private no need to use keyword private here - this is just a demo.
        internal int i; // By default all the class, structures, interfaces are internal no need to use keyword internal here - this is just a demo.
        protected int prot;
        public int pu;
        protected internal int pi;
        private protected int pp;

        // Constructor itself function - 1) No return type. 2) Name must be similar to class.
        public Encapsulation() {
            pr = 100;// Private variable only accessed inside the same class.
        }

        public void AccessibleDemoFun() {
            pr = 10; // Private variable only accessed inside the same class.
            i = 20; // Internal variable accessed within the same class as well as same namespace or assembly child class.
            prot = 30; // Protected variable can accessed inside the same class as well as direct child class.
            pi = 40; //Protected Internal variable can accessed inside the same class as well as direct child class in same namespace.
            pp = 50;// Private Protected can be accessed inside the same class as well as direct child class.
        }
    }

    //Demo 3 | Inheritance in same namespace - First Layer Inheritance.
    class EncapsulationAndInheritanceDemo:Encapsulation
    {
        // This is a child class - ITS EMPTY BECAUSE I NEED TO GAVE DEMO FOR ENCAPSULATION AS WELL AS INHERITANCE.
        public void AccessibleDemoFunOfDirectChildClass()
        {
            //pr = 10; // Private variable pr cannot be accessed inside the direct child class.
            i = 20; // Internal variable accessed within the same class as well as same namespace or assembly child class.
            prot = 30; // Protected variable can accessed inside the direct child class only.
            pi = 40;//Protected Internal variable can accessed inside the same class as well as direct child class in same namespace.
            pp = 60;// Private Protected can be accessed inside the same class as well as direct child class.
        }
    }

    // Inheritance in same namespace - Second Layer Inheritance.
    class EncapsulationAndInheritanceDemoSubChild : EncapsulationAndInheritanceDemo
    {
        public void AccessibleDemoFunOfSubChildClass()
        {
            // This is a child class - ITS EMPTY BECAUSE I NEED TO GAVE DEMO FOR ENCAPSULATION AS WELL AS INHERITANCE.
            //pr = 10; // Private variable pr cannot be accessed inside the direct child class.
            prot = 20; // Protected variable can accessed inside the direct child class but not in the sub chhild class.
            pi = 30; //Protected Internal variable can accessed inside the same class as well as direct child class in same namespace.
            i = 20; // Internal variable accessed within the same class as well as same namespace or assembly child class.
            pp = 60;// Private Protected can be accessed inside the same class as well as direct child class.
        }
    }

    //Demo 4 | Polymorphism is a Greek word, meaning "one name many forms". In other words, one object has many forms or has one name with multiple functionalities. "Poly" means many and "morph" means forms. Polymorphism provides the ability to a class to have multiple implementations with the same name. It is one of the core principles of Object Oriented Programming after encapsulation and inheritance.
    //Function overloading (static polymorphism) - Function with same name in same class with different parameters are called - function overloading | Polymorphism.
    class Polymorphism_FunctionOverloading
    {
        public void demo()
        {
            Console.WriteLine("1st demo function in Polymorphism_FunctionOverloading class - no return type, no parameter.");
        }
        public void demo(int a)
        {
            Console.WriteLine("2nd demo function in Polymorphism_FunctionOverloading class - no return type, 1 integer parameter");
        }
        public void demo(int a, char b)
        {
            Console.WriteLine("3rd demo function in Polymorphism_FunctionOverloading class - no return type, 1 integer parameter + 1 character parameter.");
        }
    }

    //Function overriding (dynamic or runtime polymorphism) - Dynamic / runtime polymorphism is also known as late binding.
    //Here, the method name and the method signature (number of parameters and parameter type must be the same and may have a different implementation). Method overriding is an example of dynamic polymorphism. Method overriding can be done using inheritance. With method overriding it is possible for the base class and derived class to have the same method name and same something.The compiler would not be aware of the method available for overriding the functionality, so the compiler does not throw an error at compile time.The compiler will decide which method to call at runtime and if no method is found then it throws an error.
    class Base_Cls
    {
        public virtual void DemoFunction()
        {
            Console.WriteLine("Base_Cls Saying Hello!");
        }
        public void DemoFunction2()
        {
            Console.WriteLine("Base_Cls Saying Hello second time!");
        }
    }
    class Derived_Cls : Base_Cls
    {
        public override void DemoFunction()
        {
            base.DemoFunction();
            Console.WriteLine("Derived_Cls Saying Hello!");
        }
        public void DemoFunction2()
        {
            Console.WriteLine("Derived_Cls Saying Hello second time!");
        }

    }
    class Derived_Sub_Cls : Derived_Cls
    {
        public override void DemoFunction()
        {
            base.DemoFunction();
            Console.WriteLine("Derived_Sub_Cls Saying Hello!");
        }
        public void DemoFunction2()
        {
            Console.WriteLine("Derived_Sub_Cls Saying Hello second time!");
        }
    }

    // Demo 5 | Abstraction
    // Abstract Class - In abstract class method can be abstract OR normal.
    // In abstract class access modifiers can be implemented.
    // Multiple inheritance is NOT possible in abstract class.
    abstract class Parent_AbsCls
    {
        public void DemoParentAbsNormal_Fun()
        {
            Console.WriteLine("Normal Method of Normal Class Named - Parent_AbsCls is called.");
        }
        public abstract void DemoParentAbsAbstract_Fun();
    }

    abstract class Abstract_CLS:Parent_AbsCls
    {
        public abstract void DemoABS_Fun();
        public void DemoNormal_Fun() {
            Console.WriteLine("Normal Method of Abstract Class Named - Abstract_CLS is called.");
        }

        public override void DemoParentAbsAbstract_Fun()
        {
            Console.WriteLine("Abstract Method of Abstract Class Named - Parent_AbsCls is called IN Abstract_CLS.");
        }
    }

    class ChildCLS_AbsDemo : Abstract_CLS
    {
        public override void DemoABS_Fun()
        {
            Console.WriteLine("Abstract Method of Abstract Class Named - Abstract_CLS is called.");
        }
        public void DemoChildNormal_Fun()
        {
            Console.WriteLine("Normal Method of Child Class Named - ChildCLS_AbsDemo is called.");
        }

        public override void DemoParentAbsAbstract_Fun()
        {
            Console.WriteLine("Abstract Method of Abstract Class Named - Parent_AbsCls is called IN ChildCLS_AbsDemo.");
        }
    }

    // Interface: All the methods in interface must be public & abstract - no need to use keyword public & abstract.
    // Multiple inheritance is possible in interface.
    interface IParent
    {
        void IAbsDemo();
    }
    interface IParent2
    {
        void IAbsDemo();
    }
    class InterfaceDemo_CLS:IParent,IParent2
    {
        void IParent.IAbsDemo()
        {
            Console.WriteLine("Interface IParent Method Override.");
        }
        void IParent2.IAbsDemo()
        {
            Console.WriteLine("Interface IParent2 Method Override.");
        }
    }
    class InterfaceDemo_CLS2 : IParent, IParent2
    {

        void IParent.IAbsDemo()
        {
            Console.WriteLine("Interface IParent Method Override.");
        }
        void IParent2.IAbsDemo()
        {
            Console.WriteLine("Interface IParent2 Method Override.");
        }
    }
    class InterfaceDemo_CLS3 : IParent, IParent2
    {

        void IParent.IAbsDemo()
        {
            Console.WriteLine("Interface IParent Method Override.");
        }
        void IParent2.IAbsDemo()
        {
            Console.WriteLine("Interface IParent2 Method Override.");
        }
    }

    // In static class all the fields and subroutines() must be static.
    // In static class no need to create an object as class name it self worked as reference.
    // In static class for single field or subroutine only one memory space will be their to store and retrieve the values.
    // When we only required the single location for field or subroutine static will be the best option.
    static class DemoStaticCLS {
        public static int a;
    }

    class DemoStaticCLSWithNormal {
        public int a1;

        // Staic field or subroutines() in normal class cannot be called by means of object.
        public static int b;
    }


    //Normal class can be inherited in sealed class.
    public class NormalSealedCLSDemo
    {
        public int a2=300;
    }

    // Sealed class never be a parent/base class.
    sealed class DemoSealedCLS: NormalSealedCLSDemo
    {
        public int InheritDemo;
    }

    public partial class DemoParCLS {
        public int p1;
    }

    public partial class DemoParCLS
    {
        public int p2;
    }

    public class ChildCLS:DemoParCLS {
        public int child;
    }
    class Program
    {
        static void Main(string[] args)
        {
            // *************************** CLASS ***********************************
            //*** NEW OBJECTS OF CLASS ClassObjectDeepDemo.***
            // First new object of class ClassObjectDeepDemo - As constructor is called.
            ClassObjectDeepDemo ClassObjectDeepDemo1 = new ClassObjectDeepDemo();
            
            // Second new object of class ClassObjectDeepDemo - As constructor is called.
            ClassObjectDeepDemo ClassObjectDeepDemo2 = new ClassObjectDeepDemo();

            // Third new object of class ClassObjectDeepDemo - As constructor is called.
            ClassObjectDeepDemo ClassObjectDeepDemo3 = new ClassObjectDeepDemo();

            // Fourth new object of class ClassObjectDeepDemo - As constructor is called.
            ClassObjectDeepDemo ClassObjectDeepDemo4 = new ClassObjectDeepDemo();

            // Fifth new object of class ClassObjectDeepDemo - As constructor is called.
            ClassObjectDeepDemo ClassObjectDeepDemo5 = new ClassObjectDeepDemo();

            //*** COPY OBJECTS OF CLASS ClassObjectDeepDemo in to newly created reference variables.***
            // First reference variable of class ClassObjectDeepDemo - which refered the object of ClassObjectDeepDemo1.
            ClassObjectDeepDemo ClassObjectDeepDemo6 = ClassObjectDeepDemo1;

            // Second reference variable of class ClassObjectDeepDemo - which refered the object of ClassObjectDeepDemo2.
            ClassObjectDeepDemo ClassObjectDeepDemo7 = ClassObjectDeepDemo2;

            // Third reference variable of class ClassObjectDeepDemo - which refered the object of ClassObjectDeepDemo3.
            ClassObjectDeepDemo ClassObjectDeepDemo8 = ClassObjectDeepDemo3;

            // Fourth reference variable of class ClassObjectDeepDemo - which refered the object of ClassObjectDeepDemo4.
            ClassObjectDeepDemo ClassObjectDeepDemo9 = ClassObjectDeepDemo4;

            // Fifth reference variable of class ClassObjectDeepDemo - which refered the object of ClassObjectDeepDemo4.
            ClassObjectDeepDemo ClassObjectDeepDemo10 = ClassObjectDeepDemo5;

            //*** COPY OF A COPY OBJECTS OF CLASS ClassObjectDeepDemo in to newly created reference variables.***
            // First reference variable of class ClassObjectDeepDemo copy reference object - which refered the object of ClassObjectDeepDemo6.
            ClassObjectDeepDemo ClassObjectDeepDemo11 = ClassObjectDeepDemo6;

            // Second reference variable of class ClassObjectDeepDemo copy reference object - which refered the object of ClassObjectDeepDemo7.
            ClassObjectDeepDemo ClassObjectDeepDemo12 = ClassObjectDeepDemo7;

            // Set values - class.
            ClassObjectDeepDemo1.a = 111;
            ClassObjectDeepDemo2.a = 222;
            ClassObjectDeepDemo3.a = 333;
            ClassObjectDeepDemo4.a = 444;
            ClassObjectDeepDemo5.a = 555;
            ClassObjectDeepDemo6.a = 666;
            ClassObjectDeepDemo7.a = 777;
            ClassObjectDeepDemo8.a = 888;
            ClassObjectDeepDemo9.a = 999;
            ClassObjectDeepDemo10.a = 1010;
            ClassObjectDeepDemo11.a = 1111;
            ClassObjectDeepDemo12.a = 1212;

            // Get values - class.
            Console.WriteLine("Value of ClassObjectDeepDemo1.a:" + ClassObjectDeepDemo1.a);
            Console.WriteLine("Value of ClassObjectDeepDemo2.a:" + ClassObjectDeepDemo2.a);
            Console.WriteLine("Value of ClassObjectDeepDemo3.a:" + ClassObjectDeepDemo3.a);
            Console.WriteLine("Value of ClassObjectDeepDemo4.a:" + ClassObjectDeepDemo4.a);
            Console.WriteLine("Value of ClassObjectDeepDemo5.a:" + ClassObjectDeepDemo5.a);
            Console.WriteLine("Value of ClassObjectDeepDemo6.a:" + ClassObjectDeepDemo6.a);
            Console.WriteLine("Value of ClassObjectDeepDemo7.a:" + ClassObjectDeepDemo7.a);
            Console.WriteLine("Value of ClassObjectDeepDemo8.a:" + ClassObjectDeepDemo8.a);
            Console.WriteLine("Value of ClassObjectDeepDemo9.a:" + ClassObjectDeepDemo9.a);
            Console.WriteLine("Value of ClassObjectDeepDemo10.a:" + ClassObjectDeepDemo10.a);
            Console.WriteLine("Value of ClassObjectDeepDemo11.a:" + ClassObjectDeepDemo11.a);
            Console.WriteLine("Value of ClassObjectDeepDemo12.a:" + ClassObjectDeepDemo12.a);

            // *************************** STUCT ***********************************
            //*** NEW REFERENCE OF STRUCT StructureReferenceDeepDemo.***
            // First new object of STRUCT StructureReferenceDeepDemo.
            StructureReferenceDeepDemo StructureReferenceDeepDemo1 = new StructureReferenceDeepDemo();

            // Second new object of STRUCT StructureReferenceDeepDemo.
            StructureReferenceDeepDemo StructureReferenceDeepDemo2 = new StructureReferenceDeepDemo();

            // Third new object of STRUCT StructureReferenceDeepDemo.
            StructureReferenceDeepDemo StructureReferenceDeepDemo3 = new StructureReferenceDeepDemo();

            // Fourth new object of STRUCT StructureReferenceDeepDemo.
            StructureReferenceDeepDemo StructureReferenceDeepDemo4 = new StructureReferenceDeepDemo();

            // Fifth new object of STRUCT StructureReferenceDeepDemo.
            StructureReferenceDeepDemo StructureReferenceDeepDemo5 = new StructureReferenceDeepDemo();

            //*** COPY OBJECTS OF STRUCT StructureReferenceDeepDemo. in to newly created reference variables.***
            // First reference variable of STRUCT StructureReferenceDeepDemo - which refered the object of StructureReferenceDeepDemo1.
            StructureReferenceDeepDemo StructureReferenceDeepDemo6 = StructureReferenceDeepDemo1;

            // Second reference variable of STRUCT StructureReferenceDeepDemo - which refered the object of StructureReferenceDeepDemo2.
            StructureReferenceDeepDemo StructureReferenceDeepDemo7 = StructureReferenceDeepDemo2;

            // Third reference variable of STRUCT StructureReferenceDeepDemo - which refered the object of StructureReferenceDeepDemo3.
            StructureReferenceDeepDemo StructureReferenceDeepDemo8 = StructureReferenceDeepDemo3;

            // Fourth reference variable of STRUCT StructureReferenceDeepDemo - which refered the object of StructureReferenceDeepDemo4.
            StructureReferenceDeepDemo StructureReferenceDeepDemo9 = StructureReferenceDeepDemo4;

            // Fifth reference variable of STRUCT StructureReferenceDeepDemo - which refered the object of StructureReferenceDeepDemo5.
            StructureReferenceDeepDemo StructureReferenceDeepDemo10 = StructureReferenceDeepDemo5;


            //*** COPY OF A COPY OBJECTS OF STRUCT StructureReferenceDeepDemo in to newly created reference variables.***
            // First reference variable of STUCT StructureReferenceDeepDemo copy reference object - which refered the object of StructureReferenceDeepDemo6.
            StructureReferenceDeepDemo StructureReferenceDeepDemo11 = StructureReferenceDeepDemo6;

            // Second reference variable of STUCT StructureReferenceDeepDemo copy reference object - which refered the object of StructureReferenceDeepDemo7.
            StructureReferenceDeepDemo StructureReferenceDeepDemo12 = StructureReferenceDeepDemo7;

            // Set values - struct.
            StructureReferenceDeepDemo1.a = 111;
            StructureReferenceDeepDemo2.a = 222;
            StructureReferenceDeepDemo3.a = 333;
            StructureReferenceDeepDemo4.a = 444;
            StructureReferenceDeepDemo5.a = 555;
            StructureReferenceDeepDemo6.a = 666;
            StructureReferenceDeepDemo7.a = 777;
            StructureReferenceDeepDemo8.a = 888;
            StructureReferenceDeepDemo9.a = 999;
            StructureReferenceDeepDemo10.a = 1010;
            StructureReferenceDeepDemo11.a = 1111;
            StructureReferenceDeepDemo12.a = 1212;

            // Get values - struct.
            Console.WriteLine("Value of StructureReferenceDeepDemo1.a:" + StructureReferenceDeepDemo1.a);
            Console.WriteLine("Value of StructureReferenceDeepDemo2.a:" + StructureReferenceDeepDemo2.a);
            Console.WriteLine("Value of StructureReferenceDeepDemo3.a:" + StructureReferenceDeepDemo3.a);
            Console.WriteLine("Value of StructureReferenceDeepDemo4.a:" + StructureReferenceDeepDemo4.a);
            Console.WriteLine("Value of StructureReferenceDeepDemo5.a:" + StructureReferenceDeepDemo5.a);
            Console.WriteLine("Value of StructureReferenceDeepDemo6.a:" + StructureReferenceDeepDemo6.a);
            Console.WriteLine("Value of StructureReferenceDeepDemo7.a:" + StructureReferenceDeepDemo7.a);
            Console.WriteLine("Value of StructureReferenceDeepDemo8.a:" + StructureReferenceDeepDemo8.a);
            Console.WriteLine("Value of StructureReferenceDeepDemo9.a:" + StructureReferenceDeepDemo9.a);
            Console.WriteLine("Value of StructureReferenceDeepDemo10.a:" + StructureReferenceDeepDemo10.a);
            Console.WriteLine("Value of StructureReferenceDeepDemo11.a:" + StructureReferenceDeepDemo11.a);
            Console.WriteLine("Value of StructureReferenceDeepDemo12.a:" + StructureReferenceDeepDemo12.a);


            //Encapsulation & Ingeritance in Class.
            Encapsulation En = new Encapsulation();
            En.i = 100; // Internal can be access in same name space at anywhere.
            En.pi = 101; // Protected Internal can be access in same name space at anywhere as well as it can be access by using child class object.
            En.pu = 102;
            
            //By Default EncapsulationAndInheritanceDemo is OOPS namespace class.
            EncapsulationAndInheritanceDemo EnI = new EncapsulationAndInheritanceDemo();
            EnI.i = 100; // Internal can be access in same name space at anywhere.
            EnI.pi = 101; // Protected Internal can be access in same name space at anywhere as well as it can be access by using child class object.
            EnI.pu = 102; // Public can be access anywhere in project.

            Console.WriteLine("Intenal Variable Value:" + En.i +"-"+EnI.i);
            Console.WriteLine("Protected Intenal Variable Value:" + En.pi + "-"+EnI.pi);
            Console.WriteLine("Public Variable Value:" + En.pu + "-"+EnI.pu);

            //By Default EncapsulationAndInheritanceDemo is OOPS namespace class.
            EncapsulationAndInheritanceDemoSubChild EnIDSC = new EncapsulationAndInheritanceDemoSubChild();
            EnIDSC.i = 100; // Internal can be access in same name space at anywhere.
            EnIDSC.pi = 101; // Protected Internal can be access in same name space at anywhere as well as it can be access by using child class object.
            EnIDSC.pu = 102; // Public can be access anywhere in project.

            Console.WriteLine("Intenal Variable Value:" + En.i + "-" + EnI.i +"-" + EnIDSC.i);
            Console.WriteLine("Protected Intenal Variable Value:" + En.pi + "-" + EnI.pi + "-" + EnIDSC.pi);
            Console.WriteLine("Public Variable Value:" + En.pu + "-" + EnI.pu + "-" + EnIDSC.pu);

            //We can call EncapsulationAndInheritanceDemo from OOPS_Demo_Inheritance namespace class ny using OOPS_Demo_Inheritance.EncapsulationAndInheritanceDemo
            OOPS_Demo_Inheritance.EncapsulationAndInheritanceDemoInDifferentNameSpace OOPSD_EnI = new OOPS_Demo_Inheritance.EncapsulationAndInheritanceDemoInDifferentNameSpace();
            OOPSD_EnI.i = 100; // Internal can be access in same name space at anywhere.
            OOPSD_EnI.pi = 101; // Protected Internal can be access in same name space at anywhere as well as it can be access by using child class object.
            OOPSD_EnI.pu = 102; // Public can be access anywhere in project.
            Console.WriteLine("Intenal Variable Value:" + En.i + "-" + EnI.i +"-"+ OOPSD_EnI.i);
            Console.WriteLine("Protected Intenal Variable Value:" + En.pi + "-" + EnI.pi + "-" + OOPSD_EnI.pi);
            Console.WriteLine("Public Variable Value:" + En.pu + "-" + EnI.pu + "-" + OOPSD_EnI.pu);


            // Function Overloading - Polymorphism.
            Polymorphism_FunctionOverloading PolyFunOverLoading = new Polymorphism_FunctionOverloading();
            PolyFunOverLoading.demo(); // demo function with no arguments.
            PolyFunOverLoading.demo(1); // demo function with one integer argument.
            PolyFunOverLoading.demo(1,'A'); // demo function with one integer argument + one character argument.

            // Function Overriding - Polymorphism.
            Base_Cls B_CLS = new Base_Cls();
            B_CLS.DemoFunction(); // Base Class function named DemoFunction() called by its own object.
            B_CLS.DemoFunction2(); // Base Class function named DemoFunction2() called by its own object.

            Derived_Cls D_CLS = new Derived_Cls();
            D_CLS.DemoFunction(); // Derived Class function named DemoFunction() called by its own object.
            D_CLS.DemoFunction2(); // Derived Class function named DemoFunction2() called by its own object.

            Derived_Sub_Cls DS_CLS = new Derived_Sub_Cls();
            DS_CLS.DemoFunction(); // Derived Class function named DemoFunction() called by its own object.
            DS_CLS.DemoFunction2(); // Derived Class function named DemoFunction2() called by its own object.


            //*** Abstraction ***
            ChildCLS_AbsDemo CCLS_AbsDemo = new ChildCLS_AbsDemo();
            CCLS_AbsDemo.DemoNormal_Fun();
            CCLS_AbsDemo.DemoABS_Fun();
            CCLS_AbsDemo.DemoChildNormal_Fun();
            CCLS_AbsDemo.DemoParentAbsNormal_Fun();
            CCLS_AbsDemo.DemoParentAbsAbstract_Fun();

            Abstract_CLS AbCLS = new ChildCLS_AbsDemo(); // Abstract class have a reference variable but no instance - abstract class reference variable can assigned by its child class instance.
            AbCLS.DemoABS_Fun();
            AbCLS.DemoNormal_Fun();
            AbCLS.DemoParentAbsNormal_Fun();
            AbCLS.DemoParentAbsAbstract_Fun();


            IParent ICls = new InterfaceDemo_CLS();
            ICls.IAbsDemo();

            ICls = new InterfaceDemo_CLS2();
            ICls.IAbsDemo();

            ICls = new InterfaceDemo_CLS3();
            ICls.IAbsDemo();


            // In static class no need to create an instance.
            DemoStaticCLS.a = 10;

            
            DemoStaticCLSWithNormal DSWN = new DemoStaticCLSWithNormal();
            DSWN.a1 = 100;
            
            // In normal class no need to create an instance for the static field.
            DemoStaticCLSWithNormal.b = 200;

            DemoParCLS DPC = new DemoParCLS();
            DPC.p1 = 300;
            DPC.p2 = 400;

            ChildCLS CCLS = new ChildCLS();
            CCLS.p1 = 1000;
            CCLS.p2 = 1000;

            Console.ReadKey();
        }
    }
}


namespace OOPS_Demo_Inheritance
{

    // Inheritance in different namespace.
    // OOPS is a name of namespace
    class EncapsulationAndInheritanceDemoInDifferentNameSpace : OOPS.Encapsulation
    {
        // This is a child class - ITS EMPTY BECAUSE I NEED TO GAVE DEMO FOR ENCAPSULATION AS WELL AS INHERITANCE.
        public void AccessibleDemoFunOfDirectChildClassInDifferentNameSpace()
        {
            // This is a child class - ITS EMPTY BECAUSE I NEED TO GAVE DEMO FOR ENCAPSULATION AS WELL AS INHERITANCE.
            //pr = 10; // Private variable pr cannot be accessed inside the direct child class.
            prot = 20; // Protected variable can accessed inside the direct child class but not in the sub chhild class.
            pi = 30; //Protected Internal variable can accessed inside the same class as well as direct child class in same namespace.
            i = 20; // Internal variable accessed within the same class as well as same namespace or assembly child class.
            pp = 60;// Private Protected can be accessed inside the same class as well as direct child class.
        }
    }

}

