using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Project1.Content;
using System.IO;

namespace Project1
{
    public class Game1 : Game
    {
        public static int screenWidth = 1280;
        public static int screenHeight = 600;
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;

        Hero theHero;
        Hut theHut;
        ghost theGhost;
        Background theBackground;

        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }

        protected override void Initialize()
        {
            // TODO: Add your initialization logic here

            _graphics.PreferredBackBufferWidth = 1200;
            _graphics.PreferredBackBufferHeight = 740;

            _graphics.ApplyChanges();


            theBackground = new Background();
            theHut = new Hut();
            theHero = new Hero();
            theGhost = new ghost();

            base.Initialize();
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);

            theHero.LoadContent(Content);
            theHut.LoadContent(Content);
            theGhost.LoadContent(Content);
            theBackground.LoadContent(Content);

            // TODO: use this.Content to load your game content here
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            theHero.Update(gameTime);
            theHut?.Update(gameTime);
            theGhost?.Update(gameTime);
            theBackground?.Update(gameTime);

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.Black);

            // TODO: Add your drawing code here

            
            
            _spriteBatch.Begin();
            theBackground.Draw(_spriteBatch);
            _spriteBatch.End();

            _spriteBatch.Begin();
            theHut.Draw(_spriteBatch);
            _spriteBatch.End(); 

            _spriteBatch.Begin();
            theHero.Draw(_spriteBatch);
            _spriteBatch.End();

            _spriteBatch.Begin();
            theGhost.Draw(_spriteBatch);
            _spriteBatch.End();
            
            base.Draw(gameTime);
        }
    }
}