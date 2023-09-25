using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using static Project1.Content.Hero;

namespace Project1
{
    class Hut : GameObjects
    {
        //attributes...

        Rectangle hutRectangle = new Rectangle(100, 0, 70, 100);


        public Hut()
        {

        }

        public override void LoadContent(Microsoft.Xna.Framework.Content.ContentManager content)
        {
            Texture = content.Load<Texture2D>("Overworld");
        }

        public override void Update(GameTime gameTime)
        {

        }

        public override void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(Texture, new Vector2(450, 150), hutRectangle, Color.White);
        }

    }
}
