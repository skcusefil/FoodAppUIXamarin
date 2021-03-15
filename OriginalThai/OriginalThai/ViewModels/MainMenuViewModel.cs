using OriginalThai.Enums;
using OriginalThai.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OriginalThai.ViewModels
{
    public class MainMenuViewModel : BaseViewModel
    {
        public List<string> MenuCatagory { get; set; }

        public MainMenuViewModel()
        {
            MenuCatagory = getCatagoryName();
        }

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
