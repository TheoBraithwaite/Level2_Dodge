﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;

namespace _2019_Level2_Dodge
{
    class Planet
    {
        //declare fields to use in the class
        public int x, y, width, height; //Variables for the rectangle
        public Image planetImage;

        public Rectangle planetRec; //Variable for a rectangle to place our image in
        public int score;
        //Create a constructor (initialises the values of the fields)
        public Planet(int spacing)
        {
            x = spacing;
            y = 10;
            width = 20;
            height = 20;
            planetImage = Image.FromFile("planet1.png");
            planetRec = new Rectangle(x, y, width, height);
        }

        public void drawPlanet(Graphics g)
        {
            planetRec = new Rectangle(x, y, width, height);
            g.DrawImage(planetImage, planetRec);
        }
        public void movePlanet()
        {
            y += 5;

            planetRec.Location = new Point(x, y);
            if(planetRec.Location.Y>400)
            {
                score += 1; //Add 1 to score when planet reaches bottom of panel
                y = 20;
                planetRec.Location = new Point(x, y);
            }
        }
    }
}
