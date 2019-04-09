using System;
using System.Collections.Generic;
using System.Text;

namespace Composite
{
    public class Composite : Component
    {
        private IList<Component> children = new List<Component>();

        public Composite(string name) : base(name)
        { }

        public override void Add(Component component)
        {
            children.Add(component);
        }

        public override void Remove(Component component)
        {
            children.Remove(component);
        }
        public override void Display(int depth)
        {
            Console.WriteLine(new String('-', depth) + name);

            foreach (Component component in children)
            {
                component.Display(depth + 2);
            }
        }
    }
}
