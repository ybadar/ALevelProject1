using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Project1.Content
{
    class ghost : GameObjects
    {
        private Vector2 Movement;
        public ghost()
        {
            Location = new Vector2(300, 300);
            Movement = new Vector2(0, 0);
        }

        public override void LoadContent(ContentManager content)
        {

            Texture = content.Load<Texture2D>("ghost"); 
        }

        public override void Update(GameTime gameTime)
        {
            Edge = new Rectangle((int)Location.X, (int)Location.Y, Texture.Width, Texture.Height);

            Movement.X = 0;
            Movement.Y = -2;

            Location = Location + Movement;

            Movement.X = 0;
            Movement.Y = +2;

            Location = Location + Movement;
        }

        

        public override void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(Texture, Location , Color.White);
        }
    }
}
