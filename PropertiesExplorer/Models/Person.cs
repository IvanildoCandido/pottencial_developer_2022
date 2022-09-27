
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PropertiesExplorer.Models
{
    public class Person
    {
        private string _name;
        private int _age;
        public string Name
        {
            get => _name.ToUpper();

            set
            {
                if (value == "")
                {
                    throw new ArgumentException("O nome da pessoa não pode ser vazio!");
                }
                _name = value;
            }
        }
        public int Age
        {
            get => _age; set
            {
                if (value < 0)
                {
                    throw new ArgumentException("A idade não pode ser menor que 'Zero'.");
                }
                _age = value;
            }
        }

        public string Meeting()
        {
            return $"Meu nome é {Name} e eu tenho {Age} anos.";
        }
    }
}

