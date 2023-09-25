using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework.Input;


namespace Project1
{
    class Background : GameObjects
    {
        public Background() 
        {

        }

        public override void LoadContent(Microsoft.Xna.Framework.Content.ContentManager content)
        {
            Texture = content.Load<Texture2D>("grass");
        }

        public override void Update(GameTime gameTime)
        {

        }

        public override void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(Texture, new Vector2(0, 0), Color.White);
        }
    }
}
