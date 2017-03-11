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
    /// <summary>
    /// This is the main type for your game
    /// </summary>
    public class SpaceInvaders : GameEnvironment
    {
        public SpaceInvaders()
        {
            Content.RootDirectory = "Content";
        }


        protected override void LoadContent()
        {
            // Create a new SpriteBatch, which can be used to draw textures.
            spriteBatch = new SpriteBatch(GraphicsDevice);
            screen = new Point(800, 600);
            this.SetFullScreen(false);

            // TODO: add gamestate to GameStateManager here

            gameStateManager.AddGameState("PlayingState",new PlayingState());
            gameStateManager.SwitchTo("PlayingState");



        }
    }
}
