using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyExercise
{
    internal class Services
    {
        #region Write Elements of List
        public void Writer<T>(IEnumerable<T> ar)
        {
            foreach (var item in ar)
            {
                Console.WriteLine(item);
            }
        }
        #endregion

        #region Remove item From List and return
        public List<T> RemoveFromList<T>(List<T> list, T item)
        {
            list.Remove(item);
            
            return list;
        }
        #endregion

    }
}
