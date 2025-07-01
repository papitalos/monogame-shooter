using Microsoft.Xna.Framework.Graphics;
using MonogameProject.Models.Base;
using MonogameProject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Formats.Asn1.AsnWriter;
using Microsoft.Xna.Framework;

namespace MonogameProject.Models
{

    public class Experience : Sprite
    {
        public float Lifespan { get; private set; }
        private const float LIFE = 5f;

        public Experience(Texture2D tex, Vector2 pos) : base(tex, pos, 0)
        {
            Lifespan = LIFE;
        }

        public void Update()
        {
            Lifespan -= Globals.Time;
            Scale = 0.33f + (Lifespan / LIFE * 0.66f);
        }

        public void Collect()
        {
            Lifespan = 0;
        }
    }
}
