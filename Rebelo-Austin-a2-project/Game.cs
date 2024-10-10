// Include code libraries you need below (use the namespace).
using System;
using System.Numerics;

// The namespace your code is in.
namespace Game10003
{
    /// <summary>
    ///     Your game code goes inside this class!
    /// </summary>
    public class Game
    {
        // Place your variables here:


        /// <summary>
        ///     Setup runs once before the game loop begins.
        /// </summary>
        public void Setup()
        {
            Window.SetTitle("Rainbow Shep");
            Window.SetSize(600, 600);
        }

        /// <summary>
        ///     Update runs every frame.
        /// </summary>
        public void Update()
        {
            Window.ClearBackground(Color.OffWhite);
            drawSheep(100, 150);
        }

        // Draw sheep legs
        void drawLegs(float x, float y)
        {
            Draw.LineSize = 0;
            Draw.FillColor = Color.White;
            Draw.Rectangle(x, y, 65, 150);
            Color feet = new Color(80, 62, 62);
            Draw.FillColor = feet;
            Draw.Rectangle(x, y + 140, 65, 10);
        }


        // Function to call a sheep drawing
        void drawSheep(float x, float y)
        // Draw sheep
        {
            Draw.LineSize = 0;
            // Head
            Draw.FillColor = Color.White;
            Draw.Square(x, y, 100);
            Draw.LineSize = 0;
            // Face
            Color Beige = new Color(184, 159, 137);
            Draw.FillColor = Beige;
            Draw.Rectangle(x - 5, y + 10, 20, 80);
            // Eye
            Draw.FillColor = Color.Black;
            Draw.Square(x - 5, y + 30, 10);
            Draw.FillColor= Color.White;
            Draw.Square(x, y + 30, 10);
            // Body
            Draw.Rectangle(x + 50, y + 50, 350, 175);
            drawLegs(x + 60, y + 175);
            drawLegs(x + 325, y + 175);
        }
    }
}
