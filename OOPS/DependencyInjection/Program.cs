using System;
namespace DependencyInjection
{
    #region Constructure Injection
    public interface I1
    {
        void Example();
    }

    class Child1 : I1
    {
        public void Example()
        {
            Console.WriteLine("Example Method of Child 1 Class Constructor Injection ");
        }
    }
    class Child2 : I1
    {
        public void Example()
        {
            Console.WriteLine("Example Method of Child 2 Class Constructor Injection ");
        }
    }

    public class ConstructorInjection
    {
        private I1 _i1;

        public ConstructorInjection(I1 _i1)
        {
            this._i1 = _i1;
        }

        public void Demo()
        {
            _i1.Example();
        }
    }
    #endregion
    #region Method Injection

    public interface I2
    {
        void Example();
    }
    public class Child11 : I2
    {
        public void Example()
        {
            Console.WriteLine("Example Class of Child11 -- Method Injection");
        }
    }

    public class DemoEX1
    {
        private I2 _i2; 
        public void DemoEXMethod(I2 _i2)
        {
            this._i2 = _i2;
            Console.WriteLine("DemoEX Class Statement Called");
            this._i2.Example();
        }
    }

    #endregion
    #region Property Injection.
    public interface I3
    {
        void ProInj(string msg);
    }

    class intClass1 : I3
    {
        public void ProInj(string msg)
        {
            Console.WriteLine("DemoPropertyInjection Method Called of intClass1 - Property Injection."+" "+msg);
        }
    }

    class intClass2 : I3
    {
        public void ProInj(string msg)
        {
            Console.WriteLine("DemoPropertyInjection Method Called of intClass2 - Property Injection."+" "+msg);
        }
    }

    class ProInject
    {
        I3 _i3=null;
        public void DProjInject(I3 i3,string msg)
        {
            this._i3 = i3;
            _i3.ProInj(msg);
        }
    }

    #endregion

    class Program
    {
        static void Main(string[] args)
        {
            #region Constructure Injection.
            ConstructorInjection CI = null;
            CI = new ConstructorInjection(new Child1());
            CI.Demo();
            CI = new ConstructorInjection(new Child2());
            CI.Demo();
            #endregion
            #region Method Injection.
            DemoEX1 CI1 = new DemoEX1();
            CI1.DemoEXMethod(new Child11());
            #endregion 
            #region Property Injection.
            ProInject PIJ = new ProInject();
            PIJ.DProjInject(new intClass1(), "Argument passed in function call.");
            PIJ.DProjInject(new intClass2(), "Argument passed in function call.");

            #endregion
        }
    }
}