using System;
using Phantom;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;

namespace Cake
{
	public class CakeGame : PhantomGame
    {
        private Texture2D newnew;
        private Texture2D white;
        private SpriteBatch batch;
		public CakeGame ()
			:base(1280, 720, "Cake")
		{
		}

        protected override void Initialize()
        {
            XnaGame.IsMouseVisible = true;
            white = Content.Load<Texture2D>("sprites/white");
            newnew = Content.Load<Texture2D>("sprites/newnew");
            batch = new SpriteBatch(this.GraphicsDevice);
            base.Initialize();
        }

        public override void Render(Phantom.Graphics.RenderInfo info)
        {
            batch.Begin();
            batch.Draw(white, new Rectangle(10, 10, 100, 100), Color.White);
            batch.Draw(white, new Rectangle(40, 50, 300, 100), Color.Black);
            batch.Draw(newnew, new Vector2(100,100), Color.White);
            batch.End();
            base.Render(info);
        }
	}
}

