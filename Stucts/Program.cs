using Stucts.BehavioralPatterns.Command;
using Stucts.BehavioralPatterns.ChainOfResponsibilities.Responsibilities;
using Stucts.CreationalPatterns.AbstractFactory.Client;
using Stucts.CreationalPatterns.AbstractFactory.Products;
using Stucts.CreationalPatterns.Builder;
using Stucts.Matrices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Stucts.DelegateHelpers;
using Stucts.BehavioralPatterns.ChainOfResponsibilities.Clients;
using Stucts.SafeHandlers;
using System.Threading;
using CrossProjectDemo;

namespace Stucts
{
    class Program
    {
        int x = 0;

        private static bool _printToConsole = false;
        private static bool _workerStarted = false;

        private static void Usage()
        {
            Console.WriteLine("Usage:");
            // Assumes that application is named HexViwer"
            Console.WriteLine("HexViewer <fileName> [-fault]");
            Console.WriteLine(" -fault Runs hex viewer repeatedly, injecting faults.");
        }

        private static void ViewInHex(Object fileName)
        {
            _workerStarted = true;
            byte[] bytes;
            using (MyFileReader reader = new MyFileReader((String)fileName))
            {
                bytes = reader.ReadContents(20);
            }  // Using block calls Dispose() for us here.

            if (_printToConsole)
            {
                // Print up to 20 bytes.
                int printNBytes = Math.Min(20, bytes.Length);
                Console.WriteLine("First {0} bytes of {1} in hex", printNBytes, fileName);
                for (int i = 0; i < printNBytes; i++)
                    Console.Write("{0:x} ", bytes[i]);
                Console.WriteLine();
            }
        }

        //string[] for = { "c#", "F#", "c++" };
        static void Main(string[] args)
        {
            #region Accessing and setting private or internal of different project using reflection
            //System.Reflection.AssemblyName assmbly = new System.Reflection.AssemblyName("CrossProjectDemo");
            //CrossProjectDemo.Car c = new CrossProjectDemo.Car();
            //Type typ = Type.GetType("CrossProjectDemo.Accessibility.Loopings, CrossProjectDemo, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null");
            //dynamic x = Activator.CreateInstance(typ);
            //x.localvar = "Not so much private";
            //var type = typ.GetField("localvar", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance);
            //type.SetValue(x,"Not so much");
            //CrossProjectDemo.Car cars = new CrossProjectDemo.Car();
            //var vars = cars.ReturnObject();
            //vars.GetEnumerator();
            //cars.Caller(x, 4);
            #endregion

            #region SafeHandle
            //if (args.Length == 0 || args.Length > 2 ||
            //    args[0] == "-?" || args[0] == "/?")
            //{
            //    Usage();
            //    return;
            //}

            //String fileName = args[0];
            //bool injectFaultMode = args.Length > 1;
            //if (!injectFaultMode)
            //{
            //    _printToConsole = true;
            //    ViewInHex(fileName);
            //}
            //else
            //{
            //    Console.WriteLine("Injecting faults - watch handle count in perfmon (press Ctrl-C when done)");
            //    int numIterations = 0;
            //    while (true)
            //    {
            //        _workerStarted = false;
            //        Thread t = new Thread(new ParameterizedThreadStart(ViewInHex));
            //        t.Start(fileName);
            //        Thread.Sleep(1);
            //        while (!_workerStarted)
            //        {
            //            Thread.Sleep(0);
            //        }
            //        t.Abort();  // Normal applications should not do this.
            //        numIterations++;
            //        if (numIterations % 10 == 0)
            //            GC.Collect();
            //        if (numIterations % 10000 == 0)
            //            Console.WriteLine(numIterations);
            //    }
            //}
            #endregion

            #region Decorator
            //Client client = new Client();

            //var simple = new ConcreteComponent();
            //Console.WriteLine("Client: I get a simple component:");
            //client.ClientCode(simple);
            //Console.WriteLine();

            //// ...as well as decorated ones.
            ////
            //// Note how decorators can wrap not only simple components but the
            //// other decorators as well.
            //ConcreteDecoratorA decorator1 = new ConcreteDecoratorA(simple);
            //ConcreteDecoratorB decorator2 = new ConcreteDecoratorB(decorator1);
            //Console.WriteLine("Client: Now I've got a decorated component:");
            //client.ClientCode(decorator2);
            #endregion

            #region Matrix spiral traverse
            //Matrix obj = new Matrix();
            //obj.SpiralTraverse_A_Matrix();
            //Console.WriteLine("_____________________********______________________");
            //obj.Process();
            #endregion

            #region Chain Of Responsibility
            //var monkey = new MonkeyHandler();
            //var squirrel = new SquirrelHandler();
            //var dog = new DogHandler();

            //new ClientProduct().Main();


            //squirrel.SetNext(monkey).SetNext(dog);

            //// The client should be able to send a request to any handler, not
            //// just the first one in the chain.
            //Console.WriteLine("Chain: Monkey > Squirrel > Dog\n");
            //Client.ClientCode(squirrel);
            //Console.WriteLine();

            //Console.WriteLine("Subchain: Squirrel > Dog\n");
            //Client.ClientCode(squirrel);
            #endregion

            //Encryption obj = new Stucts.Encryption();
            //obj.FllMatrix();
            //Result ob = new Stucts.Nullable.Result();

            #region Command
            //Invoker invoker = new Invoker();
            ////PassingDelegates delPass = new DelegateHelpers.PassingDelegates();
            ////delPass.PassDelegateMathodHere< Invoker >(invoked => { invoked.SetOnStart(new SimpleCommand("Say Hi!")); }, new SimpleCommand("Say Hi!"));
            //invoker.SetOnStart(new SimpleCommand("Say Hi!"));
            //Receiver receiver = new Receiver();
            //invoker.SetOnFinish(new ComplexCommand(receiver, "Send email", "Save report"));

            //invoker.DoSomethingImportant();
            #endregion

            #region Builder
            //// The client code creates a builder object, passes it to the
            //// director and then initiates the construction process. The end
            //// result is retrieved from the builder object.
            //var director = new Director();
            //var builder = new ConcreteBuilder();
            //director.Builder = builder;

            //Console.WriteLine("Standard basic product:");
            //director.buildMinimalViableProduct();
            //Console.WriteLine(builder.GetProduct().ListParts());

            //Console.WriteLine("Standard full featured product:");
            //director.buildFullFeaturedProduct();
            //Console.WriteLine(builder.GetProduct().ListParts());

            //// Remember, the Builder pattern can be used without a Director
            //// class.
            //Console.WriteLine("Custom product:");
            //builder.BuildPartA();
            //builder.BuildPartC();
            //Console.Write(builder.GetProduct().ListParts());
            //Console.ReadKey();
            #endregion

            Loopings obj = new Loopings();
            obj.FirstLoopMethod();

            Console.ReadLine();
        }
    }

    interface Evil
    {

    }

    enum Angels
    {

    }

    struct Demon : Evil
    {

    }

    struct StringOperation
    {
        void PrintSentence_EachWordReverse()
        {
            string sentence = "My name is Ishoo";

            int u = -1;
            Dictionary<int, char> x = new Dictionary<int, char>();
            foreach (char c in sentence)
            {
                u++;
                x.Add(u, c);
                if (c == ' ')
                {
                    for (int i = u; i >= 0; i--)
                    {
                        Console.Write(x[i]);
                    }

                    x = new Dictionary<int, char>();
                    u = -1;
                }
            }
            Console.Write(' ');
            for (int i = u; i >= 0; i--)
            {
                Console.Write(x[i]);
            }
        }
    }

    class Encryption
    {
        string Key = "Landis";
        string user = "Ishoo";
        int MatrixDimensions = 0;
        int MatrixLength = 0;
        int StartingPoint = 0;
        int[,] mat = null;
        int[,] salt = null;

        public Encryption()
        {
            CreateMatrix();
        }

        public void CreateMatrix()
        {
            MatrixDimensions = Key.Length / 2;
            mat = new int[MatrixDimensions, MatrixDimensions];
            MatrixLength = mat.Length;
            StartingPoint = (MatrixLength - Key.Length) / 2;
            salt = new int[MatrixDimensions, MatrixDimensions];
        }

        public void FllMatrix()
        {
            int k = 0;
            for (int i = 0; i < MatrixDimensions; i++)
            {
                for (int j = 0; j < mat.GetLength(0); j++)
                {
                    if (StartingPoint <= 0)
                    {
                        mat[i, j] = k < Key.Length ? Key[k] : 0;
                        salt[i, j] = Key.Length;
                        k++;
                    }
                    StartingPoint--;
                }
            }
        }
    }
}