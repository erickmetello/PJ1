using C3.XNA;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace MonoGame
{
	public class Ball : GameObject
    {
        public Paddle paddle;
        public Tiro tiro;

        public override void Load(ContentManager content)
        {
            animation.textures = new Texture2D[1];
            animation.textures[0] = content.Load<Texture2D>("alien-verde2");
            scale = 3f;

           
            velocity = new Vector2(0.0f,50.0f);

			collider.size = new Vector2( 43.0f, 33.0f );
        }

        public override void Update( GameTime gameTime )
		{
			float deltaT = ( ( float ) gameTime.ElapsedGameTime.TotalMilliseconds * 0.001f );
			position += velocity * deltaT;

            if (BoxCollider.AreColliding(this, tiro))
            {
                scale = 0;
                velocity.Y = 0;
            }
            //    color = Color.Red;
        }
    }
}
