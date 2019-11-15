using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using DinoDiner.Menu;

namespace TicTacToe.Pages
{
    public class MenuModel : PageModel
    {
        Menu menu = new Menu();

        public Menu Menu
        {
            get
            {
                return this.menu;
            }
        }

        public List<CretaceousCombo> combos
        {
            get
            {
                return Menu.AvailableCombos;
            }
        }

        public List<Entree> entrees
        {
            get
            {
                return Menu.AvailableEntrees;
            }
        }

        public List<Side> sides
        {
            get
            {
                return Menu.AvailableSides;
            }
        }

        public List<Drink> drinks
        {
            get
            {
                return Menu.AvailableDrinks;
            }
        }
      
        public void OnGet()
        {

        }
    }
}