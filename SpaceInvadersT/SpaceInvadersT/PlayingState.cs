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
    class PlayingState :GameObjectList
    {
        public Player player;
        public SpriteGameObject background;

        public PlayingState() {


            player = new Player();

            background = new SpriteGameObject("background");

            player.Position = new Vector2(400, 580);


            this.Add(background);
            this.Add(player);


        }

        public override void Update(GameTime gameTime)
        {
            base.Update(gameTime);

            player.Update();

        }



    }
}
