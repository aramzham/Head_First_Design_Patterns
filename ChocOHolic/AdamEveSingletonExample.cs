using System;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static async Task Main(string[] args)
        {
            Adam adam = Adam.GetInstance();   
            Adam anotherAdam = Adam.GetInstance();

            Console.WriteLine(adam is Adam);
            Console.WriteLine(ReferenceEquals(adam, anotherAdam));
            
            Console.ReadKey();
        }
    }
    
    public sealed class Adam : Male 
    {
        private static Adam _adam;
  
        public static Adam GetInstance() => _adam ?? (_adam = new Adam());
  
        private Adam() {Name = "Adam";}
    }

    public sealed class Eve : Female
    {
        private static Eve _eve;
  
        public static Eve GetInstance(Adam adam)
        {
            if(adam is null)
                throw new ArgumentNullException("Eve is created from the rib of Adam");
            else
                return _eve ?? (_eve = new Eve());
        }
  
        private Eve() {Name = "Eve";}
    }

    public class Male : Human
    {
        public Male(string name, Female mother, Male father) : base(name, mother, father)
        {
        }
        protected Male() { }
    }

    public class Female : Human 
    {
        public Female(string name, Female mother, Male father) : base(name, mother, father)
        {
        }
        protected Female() { }
    }

    public abstract class Human 
    {
        protected Human() { }
        public Human(string name, Female mother, Male father)
        {
            Name = name;
            if((mother is null || father is null))
                throw new ArgumentNullException();
            Mother = mother;
            Father = father;
        }
  
        public string Name {get;protected set;}
  
        public Male Father {get; protected set;}

        public Female Mother {get; protected set;}
    }
}
