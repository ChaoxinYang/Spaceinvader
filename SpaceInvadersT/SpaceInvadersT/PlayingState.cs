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
        public GameObjectList invaders;
        public Invaders blueInvaders;

        public PlayingState() {

            GameObjectList invaders = new GameObjectList();
            
            background = new SpriteGameObject("background");

            player = new Player();
            player.Position = new Vector2(400, 580);

            blueInvaders = new Invaders("blue_invader");
            blueInvaders.Position = new Vector2(200, 100);



            this.Add(background);
            this.Add(player);

            invaders.Add(blueInvaders);
            this.Add(invaders);
            
            

        }

        public override void Update(GameTime gameTime)
        {
            base.Update(gameTime);

            player.Update();

        }



    }
}
