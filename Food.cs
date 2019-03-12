using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    class Food: INotifyPropertyChanged
    {
        public int ID { get; set; }

        public int Quantity { get; set; }

        public string Name { get; set; }

        public string Category { get; set; }

        public double Price { get ; set; }

        public double TotalPrice { get { return Price * Quantity; } }

        public event PropertyChangedEventHandler PropertyChanged;

    }
}
