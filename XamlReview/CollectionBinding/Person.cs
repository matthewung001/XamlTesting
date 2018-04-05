using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XamlReview.CollectionBinding
{
    class Person : INotifyPropertyChanged
    {
        private string firstName;
        private string homeTown;
        private string lastName;

        /// <summary>
        /// Defauly Constructor
        /// </summary>
        public Person()
        {

        }
        
        public Person(string firstName, string homeTown, string lastName)
        {
            this.firstName = firstName;
            this.homeTown = homeTown;
            this.lastName = lastName;
        }

        public string FirstName
        {
            get
            {
                return this.firstName;
            }
            set
            {
                this.firstName = value;
                OnPropertyChanged("FirstName");
            }
        }

        public string HomeTown
        {
            get
            {
                return this.homeTown;
            }
            set
            {
                this.homeTown = value;
                OnPropertyChanged("HomeTown");
            }
        }

        public string LastName
        {
            get
            {
                return this.lastName;
            }
            set
            {
                this.lastName = value;
                OnPropertyChanged("LastName");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public override string ToString() => firstName;

        public void OnPropertyChanged(string property)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            handler?.Invoke(this, new PropertyChangedEventArgs(property));
        }
    }
}
