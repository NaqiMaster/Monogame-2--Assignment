using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Monogame_Lesson_2__Scaled_Images
{
    public class Game1 : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;

        Texture2D rectangleTexture, circleTexture;
        Rectangle circleEye1, circleEye2, body, head, shortLeg1, shortLeg2, longLeg1, longLeg2, mouth;
        SpriteFont titleFont;

        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }

        protected override void Initialize()
        {
            // TODO: Add your initialization logic here

            this.Window.Title = "Scaled Images";

            _graphics.PreferredBackBufferWidth = 800; // Sets the width of the window
            _graphics.PreferredBackBufferHeight = 500; // Sets the height of the window

            circleEye1 = new Rectangle(520, 70, 60, 40);
            circleEye2 = new Rectangle(620, 70, 60, 40);

            body = new Rectangle(100, 200, 500, 200);
            head = new Rectangle(500, 50, 200, 200);

            shortLeg1 = new Rectangle(450, 300, 50, 150);
            shortLeg2 = new Rectangle(100, 300, 50, 150);

            longLeg1 = new Rectangle(200, 300, 50, 200);
            longLeg2 = new Rectangle(550, 300, 50, 200);

            mouth = new Rectangle(580, 140, 40, 80);

            _graphics.ApplyChanges();

            base.Initialize();
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);

            // TODO: use this.Content to load your game content here

            rectangleTexture = Content.Load<Texture2D>("rectangle");
            circleTexture = Content.Load<Texture2D>("circle");

            titleFont = Content.Load<SpriteFont>("Title");
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            // TODO: Add your update logic here

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.DarkRed);

            _spriteBatch.Begin();

            _spriteBatch.Draw(rectangleTexture,shortLeg1, Color.Black);//ShortLeg
            _spriteBatch.Draw(rectangleTexture,longLeg1, Color.Black);//LongLeg
            _spriteBatch.Draw(rectangleTexture,longLeg2, Color.Black);//LongLeg
            _spriteBatch.Draw(rectangleTexture,shortLeg2, Color.Black);//ShortLeg
            _spriteBatch.Draw(rectangleTexture,head, Color.Black);
            _spriteBatch.Draw(rectangleTexture,body, Color.Black);

            _spriteBatch.Draw(circleTexture,circleEye2, Color.Red);
            _spriteBatch.Draw(circleTexture,circleEye1, Color.Red);
            _spriteBatch.Draw(circleTexture,mouth, Color.White);


            _spriteBatch.DrawString(titleFont,"SLAYER", new Vector2(120, 50), Color.Black);

            _spriteBatch.End();

            // TODO: Add your drawing code here

            base.Draw(gameTime);
        }
    }
}