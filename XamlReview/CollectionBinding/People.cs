using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

namespace XamlReview.CollectionBinding
{
    class People : ObservableCollection<Person>
    {
        public People()
        {
            Add(new Person("Michael", "Alexander", "Bellevue"));
            Add(new Person("Jeff", "Hay", "Redmond"));
            Add(new Person("Christina", "Lee", "Kirkland"));
            Add(new Person("Samantha", "Smith", "Seattle"));
        }
    }
}
