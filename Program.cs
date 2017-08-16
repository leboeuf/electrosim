using System;
using System.Collections.Generic;
using Electronics_poc.Models;

namespace Electronics_poc
{
    class Program
    {
        private static List<IComponent> _components = new List<IComponent>();
        static void Main(string[] args)
        {
            InitializeComponents();
        }

        private static void InitializeComponents()
        {
            var powerSource = new PowerSource();
            powerSource.Voltage = 5;

            var ground = new Ground();



            _components.Add(powerSource);
            _components.Add(ground);
        }
    }
}
