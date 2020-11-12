using System;
using System.Collections.Generic;

namespace Decorator.Examples
{
    class MainApp
    {
        static void Main()
        {
            // Create ConcreteComponent and two Decorators
            ConcreteComponent c = new ConcreteComponent();
            ConcreteDecoratorA d1 = new ConcreteDecoratorA();
            ConcreteDecoratorB d2 = new ConcreteDecoratorB();

            ChristmasTree ct = new ChristmasTree();

            ToyChristmasTreeDecorator td = new ToyChristmasTreeDecorator();
            GarlandChristmasTreeDecorator gd = new GarlandChristmasTreeDecorator();

            td.SetTree(ct);
            gd.SetTree(ct);
            td.DecotateChristmasTree();
            gd.DecotateChristmasTree();
            // Link decorators
            d1.SetComponent(c);
            d2.SetComponent(d1);

            d2.Operation();

            // Wait for user
            Console.Read();
        }
    }

    abstract class Toy { }


    class ChristmasToy : Toy
    {
        public void info()
        {
            Console.WriteLine("I`m a cool christmas toy");
        }
    }

    abstract class Tree { }
    class ChristmasTree : Tree 
    {
        private List<Toy> _toys;

        private bool _isShining;

        public void Shine()
        {
            if (_isShining)
            {
                Console.WriteLine("I`m shining");
            }
        }

        public void SwitchGarland()
        {
            _isShining = !_isShining; 
        }

        public void AddToy(Toy toy)
        {
            _toys.Add(toy);
        }
    }

    abstract class ChristmasTreeDecorator
    {
        protected ChristmasTree _tree;

        public void SetTree(ChristmasTree tree)
        {
            _tree = tree;
        }

        public abstract void DecotateChristmasTree();
    }

    class ToyChristmasTreeDecorator: ChristmasTreeDecorator
    {
        public override void DecotateChristmasTree()
        {
            _tree.AddToy(new ChristmasToy());
        }
    }

    class GarlandChristmasTreeDecorator : ChristmasTreeDecorator
    {
        public override void DecotateChristmasTree()
        {
            _tree.SwitchGarland();
        }
    }

    // "Component"
    abstract class Component
    {
        public abstract void Operation();
    }

    // "ConcreteComponent"
    class ConcreteComponent : Component
    {
        public override void Operation()
        {
            Console.WriteLine("ConcreteComponent.Operation()");
        }
    }
    // "Decorator"
    abstract class Decorator : Component
    {
        protected Component component;

        public void SetComponent(Component component)
        {
            this.component = component;
        }
        public override void Operation()
        {
            if (component != null)
            {
                component.Operation();
            }
        }
    }

    // "ConcreteDecoratorA"
    class ConcreteDecoratorA : Decorator
    {
        private string addedState;

        public override void Operation()
        {
            base.Operation();
            addedState = "New State";
            Console.WriteLine("ConcreteDecoratorA.Operation()");
        }
    }

    // "ConcreteDecoratorB" 
    class ConcreteDecoratorB : Decorator
    {
        public override void Operation()
        {
            base.Operation();
            AddedBehavior();
            Console.WriteLine("ConcreteDecoratorB.Operation()");
        }
        void AddedBehavior()
        { }
    }
}
