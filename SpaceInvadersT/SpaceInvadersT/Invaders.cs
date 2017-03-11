using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.GamerServices;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;

namespace SpaceInvadersT
{
    class Invaders: SpriteGameObject
    {
        protected SpriteSheet Itex;
        protected int shift = 50;


        public Invaders(string assetName) : base("") {

            Itex = new SpriteSheet(assetName);
            sprite = Itex;

            velocity.X = 3;
            

        }


        public void Update()
        {
            position.X += velocity.X;

            if ((position.X > SpaceInvaders.Screen.X - Itex.Width) || (position.X < 0))
            {
                position.X -= velocity.X;
                velocity.X = -velocity.X;
                position.Y += shift;
            }

        }











    }
}
