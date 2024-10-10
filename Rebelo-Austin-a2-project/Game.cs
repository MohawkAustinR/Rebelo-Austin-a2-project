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
        bool isSheepNormal = true;
        Color[] randomWool = new Color[4];

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
            // Colours in order are white, black, beige, dark brown
            Color[] sheepColors = [Color.White, Color.Black, new Color(184, 159, 137), new Color(80, 62, 62)];


            Window.ClearBackground(Color.Cyan);
            // Change colors in array
            if (Input.IsKeyboardKeyPressed(KeyboardInput.Space))
            {
                for (int i = 0; i < randomWool.Length; i++)
                {
                    randomWool[i] = Random.Color();
                }
                isSheepNormal = false;
            }
            // Draw grass
            Draw.FillColor = Color.Green;
            Draw.Rectangle(0, 400, 600, 200);
            // Check sheep for normal colours to draw normal or random
            if (isSheepNormal)
            {
                DrawSheep(100, 150, sheepColors);
            }
            else
            {
                DrawSheep(100, 150, randomWool);
            }
        }

        // Draw sheep legs
        void DrawLegs(float x, float y, Color[] sheepColors)
        {
            Draw.LineSize = 0;
            Draw.FillColor = sheepColors[0];
            Draw.Rectangle(x, y, 65, 150);
            Draw.FillColor = sheepColors[3];
            Draw.Rectangle(x, y + 140, 65, 10);
        }


        // Function to call a sheep drawing
        void DrawSheep(float x, float y, Color[] sheepColors)
        // Draw sheep
        {
            Draw.LineSize = 0;
            // Head
            Draw.FillColor = sheepColors[0];
            Draw.Square(x, y, 100);
            Draw.LineSize = 0;
            // Face
            Draw.FillColor = sheepColors[2];
            Draw.Rectangle(x - 5, y + 10, 20, 80);
            // Eye
            Draw.FillColor = sheepColors[1];
            Draw.Square(x - 5, y + 30, 10);
            Draw.FillColor = sheepColors[0];
            Draw.Square(x, y + 30, 10);
            // Body
            Draw.FillColor = sheepColors[0];
            Draw.Rectangle(x + 50, y + 50, 350, 175);
            float xOffset = 60;
            for (int i = 0; i < 2; i++)
            {
                DrawLegs(x + xOffset, y + 175, sheepColors);
                xOffset += 325 - 60;
            }
        }
    }
}
