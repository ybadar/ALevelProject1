using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Project1.Content
{
    class Hero : GameObjects
    {
        //attributes

        public enum Directions
        {
            down,
            left,
            right,
            up,
        }

        private Vector2 Movement;
        private float FrameTime = 100;
        private int Frame = 0;
        private Directions direction = Directions.down;
        private float timeExpired;

        public Hero()
        {
            Location = new Vector2(600,350);
            Movement = new Vector2(0,0);
        }

        public override void LoadContent(Microsoft.Xna.Framework.Content.ContentManager content)
        {
            Texture = content.Load<Texture2D>("heroMap");
        }

        public override void Update(GameTime gameTime)
        {
            Edge = new Rectangle((int)Location.X, (int)Location.Y, 32, 54);

            KeyboardState ks = Keyboard.GetState();

            if (ks.IsKeyDown(Keys.A))
            {
                Movement.X = -2;
                Movement.Y = 0;
                direction = Directions.left;
            }
            if (ks.IsKeyDown(Keys.D))
            {
                Movement.X = +2;
                Movement.Y = 0;
                direction = Directions.right;
            }
            if (ks.IsKeyDown(Keys.S))
            {
                Movement.X = 0;
                Movement.Y = +2;
                direction = Directions.down;
            }
            if (ks.IsKeyDown(Keys.W))
            {
                Movement.X = 0;
                Movement.Y = -2;
                direction = Directions.up;
            }
            if(ks.IsKeyDown(Keys.Space))
            {
                // attack/break
            }

            Location = Location + Movement;

            Movement.X = 0;
            Movement.Y = 0;

            timeExpired += gameTime.ElapsedGameTime.Milliseconds;

            if (timeExpired > FrameTime)
            {
                Frame = (Frame + 1) % 4;
                timeExpired = 0;
            }
        }

        public override void Draw(SpriteBatch spriteBatch)
        {
            int X = Frame * 32;
            int Y = ((int )direction * 54); 
            spriteBatch.Draw(Texture, Location, new Rectangle(X,Y,32,54), Color.White);
        }
    }
}
