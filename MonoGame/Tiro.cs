using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace MonoGame
{
    public class Tiro : GameObject
    {
        public override void Load(ContentManager content)
        {
            animation.textures = new Texture2D[1];
            animation.textures[0] = content.Load<Texture2D>("BallSprite");
            scale = 0.1f;
            collider.size = new Vector2(15.0f, 15.0f);
        }

        public override void Update(GameTime gameTime)
        {
            float deltaT = ((float)gameTime.ElapsedGameTime.TotalMilliseconds * 0.001f);
            position += velocity * deltaT;

            animation.Animate(gameTime);
        }
    }
}
