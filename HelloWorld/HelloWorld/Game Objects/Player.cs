using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using SpriteLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HelloWorld.Game_Objects
{
    public class Player
    {
        #region Variables
        List<Sprite> sprites;
        #endregion

        #region Properties
        public List<Sprite> Sprites
        {
            set { sprites = value; }
            get
            {
                if (sprites == null)
                    sprites = new List<Sprite>();

                return sprites;
            }
        }
        public Texture2D Texture { get; set; }
        public Vector2 Position { get; set; }
        public Rectangle ImageRect { get; set; }
        #endregion

        #region Events
        #endregion

        #region Constructors
        #endregion

        #region Methods
        public void Initialize(List<Sprite> sprites, Vector2 position, Rectangle imageRect)
        {
            Sprites = sprites;
            Position = position;
            ImageRect = imageRect;
        }

        public void Update(GameTime gameTime)
        {
            if (Sprites.Count > 0)
                Sprites[0].Update(gameTime);

            Sprites[0].Position = Position;
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            if (Sprites.Count > 0)
                Sprites[0].Draw(spriteBatch);
        }
        #endregion
    }
}
