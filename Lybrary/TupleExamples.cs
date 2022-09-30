using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lybrary.Models
{
    public class TupleExamples
    {
        public (int id, string name, int age) person()
        {
            return (1, "Ivanildo", 35);
        }
    }
}