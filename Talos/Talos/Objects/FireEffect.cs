using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Talos.Objects {
    public class FireEffect : DrawableGameComponent {
        private SpriteBatch batch;
        private Texture2D fire;

        private float x, y, size, rotation;
        private readonly float velocityX, velocityY, velocitySize, velocityRotation;

        public override void Draw(GameTime gameTime) {
            batch.Begin(samplerState: SamplerState.PointClamp);
            batch.Draw(fire, new Rectangle((int)x, (int)y, (int)size, (int)size), null, Color.White,
                rotation, Vector2.Zero, SpriteEffects.None, 0);
            batch.End();

            base.Draw(gameTime);
        }

        public override void Update(GameTime gameTime) {
            var timePassed = (float)gameTime.ElapsedGameTime.TotalMilliseconds;
            
            x += velocityX * timePassed;
            y += velocityY * timePassed;
            size += velocitySize * timePassed;
            rotation += velocityRotation * timePassed;

            if (size <= 0) {
                Game.Components.Remove(this);
            }
            
            base.Update(gameTime);
        }
        
        protected override void LoadContent() {
            batch = new SpriteBatch(Game.GraphicsDevice);
            
            fire = Game.Content.Load<Texture2D>("fire");
            
            base.LoadContent();
        }

        public FireEffect(Game game, float x, float y) : base(game) {
            this.x = x;
            this.y = y;

            var random = new Random();

            size = (float)(random.NextDouble() * 50 + 10);
            rotation = (float)(random.NextDouble() * 0.2 - 0.1);
            
            velocityX = (float)(random.NextDouble() * 1 - 0.5);
            velocityY = (float)(random.NextDouble() * 1 - 0.5);
            velocitySize = (float)(random.NextDouble() * -0.005 - 0.0025);
            velocityRotation = (float)(random.NextDouble() * 0.002 - 0.001);
        }
    }
}