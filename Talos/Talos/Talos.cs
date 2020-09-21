using Talos.Objects;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Talos {
    public class Talos : Game {
        private readonly GraphicsDeviceManager manager;

        private float timeToGo;
        private const float timeTillParticle = 10;

        protected override void Draw(GameTime gameTime) {
            GraphicsDevice.Clear(Color.Black);

            base.Draw(gameTime);
        }

        protected override void Initialize() {
            Components.Add(new Player(this));
            
            base.Initialize();
        }

        public Talos() {
            manager = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content/bin";
        }
    }
}