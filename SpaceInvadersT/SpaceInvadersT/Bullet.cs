using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;

namespace SpaceInvadersT
{
    class Bullet : SpriteGameObject
    {

        public Bullet() : base("bullet")
        {

            velocity.Y = -5;
        }

        public override void Update(GameTime gameTime)
        {
            base.Update(gameTime);
            this.position += velocity;
           


        }


        public override void Reset()
        {
            base.Reset();
            visible = false;
            velocity.Y = 0;
        }
    }
}