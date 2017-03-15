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
    class TitleScreenState :GameObjectList
    {
        public SpriteGameObject background;
        public TitleScreenState()
        {
            background = new SpriteGameObject("background");


            this.Add(background);

        }

        public override void HandleInput(InputHelper inputHelper)
        {
            base.HandleInput(inputHelper);
            if (inputHelper.KeyPressed(Keys.Space))
            {

                SpaceInvaders.GameStateManager.SwitchTo("PlayingState");

            }

        }





    }
}
