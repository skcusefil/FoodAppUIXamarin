using System;
using System.Collections.Generic;
using System.Text;

namespace OriginalThai.ViewModels
{
    public class FoodViewModel : BaseViewModel
    {
        private int _id;
        private string _name;
        private string _catagory;
        private double _price;
        private string _detail;

        public int Id { get => _id; set => SetProperty(ref _id,value); }
        public string Name { get => _name; set => SetProperty(ref _name, value); }
        public string Category { get => _catagory; set => SetProperty(ref _catagory, value); }
        public double Price { get => _price; set => SetProperty(ref _price, value); }
        public string Detail { get => _detail; set => SetProperty(ref _detail, value); }

    }
}
