using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.GamerServices;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;

namespace SpaceInvadersT
{
    class Player : SpriteGameObject
    {

        public Vector2 punt;
       
        public Player() : base("ship")
        {
            punt.X = (0.1f);

        }

        public  bool Update()
        {
            // Assume player is not moving
           velocity.X = 0;

            // Alter velocity when keys are pressed
            // if (Global.keys.IsKeyDown(Keys.Left)) velocity.X = -10.0f;
            // if (Global.keys.IsKeyDown(Keys.Right)) velocity.X = 10.0f;

            //position += velocity;

            // If x position is out of bounds, "undo" velocity
            if ((position.X < 100) || (position.X > SpaceInvaders.Screen.X - Width - 100))
            {
               
                position -= velocity;
                Console.WriteLine("S");
            }
          
           
            return true;
        }



        public override void HandleInput(InputHelper inputHelper)
        {
            base.HandleInput(inputHelper);
            if (inputHelper.IsKeyDown(Keys.Left) )
            {
             velocity.X = -5;
             position += velocity;
                if ((position.X < 100) || (position.X > SpaceInvaders.Screen.X - Width - 100))
                {
                    
                    position -= (velocity-punt);
                    Console.WriteLine("S");
                }


            }
            if (inputHelper.IsKeyDown(Keys.Right) )
            {
                velocity.X = 5;
                position += velocity;
                if ((position.X < 100) || (position.X > SpaceInvaders.Screen.X - Width - 100))
                {
                    
                    position -= (velocity + punt);
                    Console.WriteLine("S");
                }
             
            }
            


        }

    }
}
