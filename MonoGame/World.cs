using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using System.Collections.Generic;

namespace MonoGame
{
    public class World
    {
        private List<GameObject> gameObjects;
        private ContentManager content;

        public void InstantiateObject(GameObject gameObject)
        {
            gameObjects.Add(gameObject);
            gameObject.world = this;
            gameObject.Load(content);
        }

        public void LoadObjects(ContentManager contentManager)
        {
            gameObjects = new List<GameObject>();
            content = contentManager;


            Wall topWall = new Wall();
            topWall.position = new Vector2(0.0f, 0.0f);
            topWall.collider.size = new Vector2(1000.0f, 10.0f);
            InstantiateObject(topWall);

            Wall leftWall = new Wall();
            leftWall.position = new Vector2(0.0f, 0.0f);
            leftWall.collider.size = new Vector2(10.0f, 1000.0f);
            InstantiateObject(leftWall);

            Wall rightWall = new Wall();
            rightWall.position = new Vector2(790.0f, 0.0f);
            rightWall.collider.size = new Vector2(10.0f, 1000.0f);
            InstantiateObject(rightWall);

            
            Tiro tiro = new Tiro();
            InstantiateObject(tiro);
            tiro.position = new Vector2(999999.0f, 400.0f);
            tiro.velocity = new Vector2(0.0f, -400.0f);

            Paddle paddle = new Paddle();
            InstantiateObject(paddle);
            paddle.tiro = tiro;


            Ball ball = new Ball();
            ball.paddle = paddle;
            ball.tiro = tiro;
            ball.position = new Vector2(250.0f, 0.0f);
            InstantiateObject(ball);

            Ball ball2 = new Ball();
            ball2.paddle = paddle;
            ball2.tiro = tiro;
            ball2.position = new Vector2(200.0f, 0.0f);
            InstantiateObject(ball2);

            Ball ball3 = new Ball();
            ball3.paddle = paddle;
            ball3.tiro = tiro;
            ball3.position = new Vector2(300.0f, 0.0f);
            InstantiateObject(ball3);

            Ball ball4 = new Ball();
            ball4.paddle = paddle;
            ball4.tiro = tiro;
            ball4.position = new Vector2(350.0f, 0.0f);
            InstantiateObject(ball4);

            Ball ball5 = new Ball();
            ball5.paddle = paddle;
            ball5.tiro = tiro;
            ball5.position = new Vector2(150.0f, 0.0f);
            InstantiateObject(ball5);


        }

        public void UpdateObjects(GameTime gameTime)
        {
            for(int i = 0; i < gameObjects.Count; i++)
            {
                GameObject obj = gameObjects[i];
                obj.Update(gameTime);
            }
        }

        public void DrawObjects(SpriteBatch spriteBatch)
        {
            foreach (GameObject obj in gameObjects)
            {
                obj.Draw(spriteBatch);
            }
        }
    }
}
