using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Talos.Objects {
    public class Player : DrawableGameComponent {
        private SpriteBatch batch;

        private Texture2D texture;
        
        public override void Draw(GameTime gameTime) {
            base.Draw(gameTime);
        }

        public override void Update(GameTime gameTime) {
            base.Update(gameTime);
        }

        protected override void LoadContent() {
            batch = new SpriteBatch(Game.GraphicsDevice);
            
            texture = new Texture2D(Game.GraphicsDevice, 1, 1);
            texture.SetData(new int[]{ 1, 2, 3 });
            
            base.LoadContent();
        }

        public Player(Game game) : base(game) {
            
        }
    }
}