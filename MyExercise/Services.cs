using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyExercise
{
    internal class Services : BaseServices
    {
        #region Write Elements of List
        public override void WriterItems<T>(IEnumerable<T> ar)
        {
            foreach (var item in ar.ToList())
            {
                Console.WriteLine(item);
            }
        }

        public override void WriterItem<T>(T item)
        {
            Console.WriteLine(item);
        }
        #endregion

        #region Remove item From List and return
        public List<T> RemoveFromList<T>(List<T> list, T item)
        {
            list.Remove(item);
            
            return list;
        }
        #endregion


        #region Find item From List and return this
        public T FindFromList<T>(List<T> list, T item)
        {
            T result = list.Find(x => x.Equals(item));

            return result;
        }
        #endregion
    }
}
