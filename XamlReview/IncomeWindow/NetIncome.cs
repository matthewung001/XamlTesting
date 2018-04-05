using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace XamlReview.IncomeWindow
{
    class NetIncome : INotifyPropertyChanged
    {
        private int totalIncome = 5000;
        private int rent = 2000;
        private int food = 0;
        private int misc = 0;
        private int savings = 0;

        public NetIncome()
        {
            savings = totalIncome - (rent + food + misc);
        }

        public int TotalIncome
        {
            get
            {
                return totalIncome;
            }
            set
            {
                totalIncome = value;
                OnPropertyChanged("TotalIncome");
                UpdateSavings();
            }
        }

        public int Rent
        {
            get
            {
                return rent;
            }
            set
            {
                rent = value;
                OnPropertyChanged("Rent");
                UpdateSavings();
            }
        }

        public int Food
        {
            get
            {
                return food;
            }
            set
            {
                food = value;
                OnPropertyChanged("Food");
                UpdateSavings();
            }
        }

        public int Misc
        {
            get
            {
                return misc;
            }
            set
            {
                misc = value;
                OnPropertyChanged("Misc");
                UpdateSavings();
            }
        }

        public int Savings
        {
            get
            {
                return savings;
            }
            set
            {
                savings = value;
                OnPropertyChanged("Savings");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged(string property)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            handler?.Invoke(this, new PropertyChangedEventArgs(property));
        }

        /// <summary>
        /// Update the savings if a property happens to change
        /// </summary>
        private void UpdateSavings()
        {
            Savings = this.totalIncome - (this.misc + this.rent + this.food);
        }
    }
}
