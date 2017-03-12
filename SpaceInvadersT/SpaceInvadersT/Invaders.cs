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

            velocity.X = 2;

        }


        public override void Update(GameTime gameTime)
        {
            this.position.X += this.velocity.X;
            
            if ((this.position.X > SpaceInvaders.Screen.X - Itex.Width) || (this.position.X < 0))
            {
                this.position.X -= this.velocity.X;
                this.velocity.X = -this.velocity.X;
                this.position.Y += shift;
            }


        }











    }
}
