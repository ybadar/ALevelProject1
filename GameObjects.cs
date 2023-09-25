using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Content;

namespace Project1
{
    class GameObjects
    {
        public Vector2 Location;
        protected Texture2D Texture;
        public Rectangle Edge;
         
        public virtual void LoadContent ( ContentManager content)
        {

        }

        public virtual void Update(GameTime gameTime)
        {

        }

        public virtual void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(Texture, Location, Color.White);
        }

    }
}
