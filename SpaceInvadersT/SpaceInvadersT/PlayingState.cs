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
        private GameObjectList invaders;
        

        

        public PlayingState() {

            GameObjectList invaders = new GameObjectList();
            
            background = new SpriteGameObject("background");

            player = new Player();
            player.Position = new Vector2(400, 580);

            
            for(int totalInvaders = 0; totalInvaders< 9; totalInvaders++)
            {


                Invaders blueInvaders = new Invaders("blue_invader");
                blueInvaders.Position = new Vector2(totalInvaders * 60, 20);
                blueInvaders.Velocity = new Vector2(4);
                
                invaders.Add(blueInvaders);

                

            }
            for (int totalInvaders = 0; totalInvaders < 9; totalInvaders++)
            {


                Invaders greenInvaders = new Invaders("green_invader");
                greenInvaders.Position = new Vector2(totalInvaders * 60, 70);
                greenInvaders.Velocity = new Vector2(3);

                invaders.Add(greenInvaders);



            }
            for (int totalInvaders = 0; totalInvaders < 9; totalInvaders++)
            {


                Invaders yellowInvaders = new Invaders("yellow_invader");
                yellowInvaders.Position = new Vector2(totalInvaders * 60, 120);
                yellowInvaders.Velocity = new Vector2(2);

                invaders.Add(yellowInvaders);



            }

            for (int totalInvaders = 0; totalInvaders < 9; totalInvaders++)
            {


                Invaders redInvaders = new Invaders("red_invader");
                redInvaders.Position = new Vector2(totalInvaders * 60, 170);
                redInvaders.Velocity = new Vector2(1);

                invaders.Add(redInvaders);



            }

            this.Add(background);
            this.Add(player);

            
            this.Add(invaders);
            
            

        }

        public override void Update(GameTime gameTime)
        {
            base.Update(gameTime);

            player.Update();
          
            
            
        }



    }
}
