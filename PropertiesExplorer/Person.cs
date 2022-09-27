
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PropertiesExplorer.Models
{
    public class Person
    {
        private string _name;
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
        public int Age { get; set; }

        public string Meeting()
        {
            return $"Meu nome é {Name} e eu tenho {Age} anos.";
        }
    }
}

