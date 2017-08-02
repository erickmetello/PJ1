using C3.XNA;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace MonoGame
{
    public class Paddle : GameObject
    {
        public Tiro tiro;

        public override void Load(ContentManager content)
        {
            animation.textures = new Texture2D[1];
            color = Color.White;
            scale = 3;
            position = new Vector2( 250.0f, 400.0f );
            collider.size = new Vector2(50.0f, 30.0f);
            animation.textures[0] = content.Load<Texture2D>("alien-vermelho");
        }

        public override void Update(GameTime gameTime)
        {
            if (Keyboard.GetState().IsKeyDown(Keys.Space))
            {
                tiro.position = position;
                tiro.velocity = new Vector2(0.0f, -100.0f);
            }



            if (Keyboard.GetState().IsKeyDown(Keys.Right))
            {
                position.X += 4.0f;
            }
            else if (Keyboard.GetState().IsKeyDown(Keys.Left))
            {
                position.X -= 4.0f;
            }
        }
        
        
    }
}
