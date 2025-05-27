using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZbieraczPunktowMaui
{
    internal class Player
    {
        int height;
        int width;
        int[] Positon;
        public Image image;
        public Player() { 
            height = 100; 
            width = 100; 
            Positon = new int[2];
            image = new Image();
            image.Source = ImageSource.FromFile("player.png");
            
        }
    }
}
