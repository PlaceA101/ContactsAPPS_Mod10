using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactsApp_placean.Models
{
    public class Group<K, T> : ObservableCollection<T>
    {
        public K Key { get; }

        public Group(K key, IEnumerable<T> items) : base(items)
        {
            Key = key;
        }
    }

}
