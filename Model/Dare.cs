using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DaresGacha.Model
{
    public class Dare
    {
        public int Id { get; set; }
        public string Text { get; set; } = string.Empty;
        public int Level { get; set; }
    }
}