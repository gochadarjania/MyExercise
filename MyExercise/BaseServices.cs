using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyExercise
{
    abstract class BaseServices
    {
        public virtual void WriterItems<T>(IEnumerable<T> ar){}
        public virtual void WriterItem<T>(T item){ }
    }
}
