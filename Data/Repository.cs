using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETrocas.Data {
    internal class Repository<T>  {
        public void Add(T item) {
            List<T> list = new List<T>();
            list.Add(item);
        }
        public void Delete(T item) {
            List<T> list = new List<T>();
            list.Remove(item);
        }

    }
}
