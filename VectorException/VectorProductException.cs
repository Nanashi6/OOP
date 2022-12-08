using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VectorException
{
    // Несовпадение измерений в которых представлены векторы
    public class VectorProductException : Exception
    {
        public VectorProductException(string message = "Ввиду немощности программиста векторное произведение работает только для трёхмерных векторов") : base(message)
        {
        }
    }
}
