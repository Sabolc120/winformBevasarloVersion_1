using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bevasarlo
{
    internal class Price
    {
        private decimal bananaPrice = 200;
        private decimal potatoPrice = 80;
        private decimal tomatoPrice = 100;
        private decimal onionPrice = 50;
        private decimal eggplantPrice = 300;
        private decimal strawberryPrice = 270;
        private decimal pineapplePrice = 600;
        private decimal cucumberPrice = 140;
        private decimal paprikaPrice = 80;
        private decimal saladPrice = 180;

        public decimal BananaPrice { get => bananaPrice; set => bananaPrice = value; }
        public decimal PotatoPrice { get => potatoPrice; set => potatoPrice = value; }
        public decimal TomatoPrice { get => tomatoPrice; set => tomatoPrice = value; }
        public decimal OnionPrice { get => onionPrice; set => onionPrice = value; }
        public decimal EggplantPrice { get => eggplantPrice; set => eggplantPrice = value; }
        public decimal StrawberryPrice { get => strawberryPrice; set => strawberryPrice = value; }
        public decimal PineapplePrice { get => pineapplePrice; set => pineapplePrice = value; }
        public decimal CucumberPrice { get => cucumberPrice; set => cucumberPrice = value; }
        public decimal PaprikaPrice { get => paprikaPrice; set => paprikaPrice = value; }
        public decimal SaladPrice { get => saladPrice; set => saladPrice = value; }
    }
}
