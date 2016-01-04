using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParticleTest
{
    public class Particle
    {
        public float x;
        public float y;

        private TimeSpan _life;
        private DateTime _birth;

        public Color color;

        public float velocity_x;
        public float velocity_y;

        /// <summary>
        /// creates a particle.
        /// </summary>
        /// <param name="x">start position at x</param>
        /// <param name="y">start position at y</param>
        /// <param name="life">lifetime in seconds</param>
        /// <param name="angle">movement angle in degrees</param>
        /// <param name="speed">movment speed in px per second</param>
        public Particle(float x, float y, int life, float angle, float speed, Color col)
        {
            this.x = x;
            this.y = y;
            this._birth = DateTime.Now;
            this._life = new TimeSpan(0, 0, 0, life);
            float angleRad = (float)(angle * Math.PI / 180); //convert angle in degrees to rad for x and y velocity
            this.velocity_x = (float)(speed * Math.Cos(angleRad));
            this.velocity_y = (float)(speed * Math.Sin(angleRad));

            this.color = col;
        
        }

        /// <summary>
        /// updatyes a particles state
        /// </summary>
        public bool update()
        {
            if (DateTime.Now - _birth > _life)
                return true;
            else {
                //int newlastupdate = DateTime.Now.Millisecond;
                //int lapsedtime = newlastupdate - lastupdate;
                //this.life -= lapsedtime;

                this.x += this.velocity_x;
                this.y += this.velocity_y;
                this.velocity_y += 0.05f;

                return false;
            }

        }

        public void Draw(Graphics g)
        {
                double mstotallive = this._life.TotalMilliseconds;
                double mslive = (DateTime.Now - _birth).TotalMilliseconds;
                double percentlife = mslive / mstotallive;
            if (percentlife > 1)
                percentlife = 1.0d;

                Color col = Color.FromArgb(255 - ((int)(percentlife * 255)), this.color);

                g.DrawEllipse(new Pen(col), this.x - 2, this.y - 2, 4, 4);
        }

    }
}
