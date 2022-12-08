using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VectorException
{
    // Несовпадение измерений в которых представлены векторы
    public class ScalarProductException : Exception
    {
        public ScalarProductException(string message = "Скалярное произведение не может быть найдено") : base(message)
        {
        }
    }
}
