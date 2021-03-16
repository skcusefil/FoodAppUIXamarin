using OriginalThai.Enums;
using OriginalThai.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace OriginalThai.ViewModels
{
    public class MainMenuViewModel : BaseViewModel
    {

        public List<string> MenuCatagory { get; set; }

        private List<FoodViewModel> _foodList;
        public List<FoodViewModel> FoodList { get=>_foodList ; set=>SetProperty(ref _foodList,value); }

        private FoodViewModel _food;
        public FoodViewModel Food 
        {
            get => _food;
            set => SetProperty(ref _food, value);
        }

        public MainMenuViewModel()
        {
            MenuCatagory = getCatagoryName();
            LoadFoods(string.Empty);
            InitializeCommand();
        }

        private void InitializeCommand()
        {
            MenuSelectCommand = new Command<string>(menu =>LoadFoods(menu));
        }

        private List<FoodViewModel> CreateFoodList()
        {

            var foodList = new List<FoodViewModel>()
            {
                new FoodViewModel { Id=1, Category=Category.Central.ToString() ,Detail="Detail 1", Name="Food 1", Price=10.50, Photo ="sweetsauer.jpg"},
                new FoodViewModel { Id=2, Category=Category.Central.ToString() ,Detail="Detail 2", Name="Food 2", Price=10.50, Photo="tomyamkung.jpg"},
                new FoodViewModel { Id=3, Category=Category.Central.ToString() ,Detail="Detail 3", Name="Food 3", Price=10.50, Photo="greencurry.jpg"},

                new FoodViewModel { Id=4, Category=Category.North.ToString() ,Detail="Detail 4", Name="Food 4", Price=10.50, Photo="khaosoi.jpg"},
                new FoodViewModel { Id=5, Category=Category.North.ToString() ,Detail="Detail 5", Name="Food 5", Price=10.50, Photo="sai_uar.jpg"},
                new FoodViewModel { Id=6, Category=Category.North.ToString() ,Detail="Detail 6", Name="Food 6", Price=10.50, Photo="sai_uar.jpg"},

                new FoodViewModel { Id=7, Category=Category.Northeast.ToString() ,Detail="Detail 7", Name="Food 7", Price=10.50, Photo="labmoo.jpg"},
                new FoodViewModel { Id=8, Category=Category.Northeast.ToString() ,Detail="Detail 8", Name="Food 8", Price=10.50, Photo="papaya_salat.jpg"},
                new FoodViewModel { Id=9, Category=Category.Northeast.ToString() ,Detail="Detail 9", Name="Food 9", Price=10.50, Photo="supnormai.jpg"},

                new FoodViewModel { Id=10, Category=Category.South.ToString() ,Detail="Detail 10", Name="Food 10", Price=10.50, Photo="massamankai.jpg"},
                new FoodViewModel { Id=11, Category=Category.South.ToString() ,Detail="Detail 11", Name="Food 11", Price=10.50, Photo="massamannua.jpg"},
                new FoodViewModel { Id=12, Category=Category.South.ToString() ,Detail="Detail 12", Name="Food 12", Price=10.50, Photo="taiplasoup.jpg"}
            };

            return foodList;
        }

        private void LoadFoods(string menu)
        {

            FoodList = new List<FoodViewModel>();
            FoodList = CreateFoodList();

            if(menu == "Nordthailand")
            {
                FoodList = FoodList.Where(food => food.Category.Equals(Category.North.ToString())).ToList();

            }
            else if (menu == "Nordostthailand")
            {
                FoodList = FoodList.Where(food => food.Category.Equals(Category.Northeast.ToString())).ToList();

            }
            else if (menu == "Südthailand")
            {
                FoodList = FoodList.Where(food => food.Category.Equals(Category.South.ToString())).ToList();

            }
            else
            {
                FoodList = FoodList.Where(food => food.Category.Equals(Category.Central.ToString())).ToList();

            }




        }

        public ICommand MenuSelectCommand { get; private set; }

        private List<string> getCatagoryName()
        {
            var categories = Enum.GetNames(typeof(Category)).ToList();

            var menuCatagory = new List<string>();

            foreach (var item in categories)
            {
                if(item == Category.Central.ToString())
                {
                    menuCatagory.Add("Zentralthailand");
                }
                else if(item == Category.North.ToString())
                {
                    menuCatagory.Add("Nordthailand");
                }
                else if (item == Category.Northeast.ToString())
                {
                    menuCatagory.Add("Nordostthailand");
                }
                else if (item == Category.South.ToString())
                {
                    menuCatagory.Add("Südthailand");
                }
            }

            return menuCatagory;
        }
    }
}
