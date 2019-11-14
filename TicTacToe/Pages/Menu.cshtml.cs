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
        public Menu menu { get; }

        public double Price
        {
            get
            {
                return menu.Price
            }
        }

        public void OnGet()
        {

        }
    }
}