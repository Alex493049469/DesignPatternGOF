using System;

namespace DesignPatternGOF.Creational.FactoryMethod
{
    abstract class Product
    {
        abstract public string GetType();
    }

    class ConcreteProductA : Product
    {
        public override string GetType() { return "ConcreteProductA"; }
    }

    class ConcreteProductB : Product
    {
        public override string GetType() { return "ConcreteProductB"; }
    }

    abstract class Creator
    {
        public abstract Product FactoryMethod();
    }

    class ConcreteCreatorA : Creator
    {
        public override Product FactoryMethod() { return new ConcreteProductA(); }
    }

    class ConcreteCreatorB : Creator
    {
        public override Product FactoryMethod() { return new ConcreteProductB(); }
    }

    public class MainApp
    {
        public void Main()
        {
            // массив создателей
            Creator[] creators = { new ConcreteCreatorA(), new ConcreteCreatorB() };
            // перебрать создателей и создания продуктов
            foreach (Creator creator in creators)
            {
                Product product = creator.FactoryMethod();
                Console.WriteLine("Created {0}", product.GetType());
            }
           
            Console.Read();
        }
    }
}
