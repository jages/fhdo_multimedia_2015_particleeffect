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
        public float _x;
        public float _y;

        private float _velocity_x;
        private float _velocity_y;

        private float _gravity_x;
        private float _gravity_y;

        private TimeSpan _life;
        private DateTime _birth;

        private Color _color;

        private bool _decay;

        

        /// <summary>
        /// Creates a particle
        /// </summary>
        /// <param name="x">starting position horizontal</param>
        /// <param name="y">starting position vertical</param>
        /// <param name="gravity_x">'windeffect' - 'pull' towards horizontal infinity, negative values for 'push'</param>
        /// <param name="gravity_y">'gravityeffect' - 'pull' towards vertical infinity, negative values for 'push'</param>
        /// <param name="life">lifetime in seconds</param>
        /// <param name="angle">angle in degrees. 0 is straight left, 90 is straight down</param>
        /// <param name="speed">speed in pixels per update</param>
        /// <param name="col">color of particle</param>
        /// <param name="decay">if true, will fade based on % of lifetime left. - only affects alpha of color in draw</param>
        public Particle(float x, float y,float gravity_x, float gravity_y, int life, float angle, float speed, Color col, bool decay)
        {
            //set default values for movement and behavior
            this._x = x;
            this._y = y;
            this._gravity_x = gravity_x;//default was 0.0f
            this._gravity_y = gravity_y;//default was 0.05f
            this._decay = decay;//default was true
            this._color = col;
            
            //calculate movement direction from angle and speed into a velocity vector (easier to set in GUI)
            float angleRad = (float)(angle * Math.PI / 180); //convert angle in degrees to rad for x and y velocity
            this._velocity_x = (float)(speed * Math.Cos(angleRad));
            this._velocity_y = (float)(speed * Math.Sin(angleRad));

            //complete all calculations before 'birth'
            this._birth = DateTime.Now;
            this._life = new TimeSpan(0, 0, 0, life);

        }

        /// <summary>
        /// updates particle state
        /// </summary>
        /// <returns>returns true if particle is ready to die</returns>
        public bool update()
        {
            //return true if lifetime is over, don#t bother updating a dead particle
            if (DateTime.Now - _birth > _life)
                return true;
            else {
                
                //update particle position based on velocity
                this._x += this._velocity_x;
                this._y += this._velocity_y;

                //TODO need a more eelegant solution to gravity / wind
                this._velocity_y += _gravity_y;//default gravity was 0.05f
                this._velocity_x += _gravity_x;//default wind was 0

                return false;
            }

        }

        /// <summary>
        /// draws particle onto graphics
        /// </summary>
        /// <param name="g">graphics object the particle is painted upon</param>
        public void Draw(Graphics g)
        {
            double percentlife = 0;//defult to 0, if no decay is set, alpha will always be set to 255
            if (_decay)
            {
                //total lifetime in ms
                double mstotallive = this._life.TotalMilliseconds;
                //time already lapsed since birth in ms
                double mslive = (DateTime.Now - _birth).TotalMilliseconds;
                //percentage of maximum lifetime lived
                percentlife = mslive / mstotallive;
                /* due to asynchronos calls, a particle can outlive it's lifetime by a marginal amount
                 * following flattening of values will ensure that the alpha value can be set correctly, or it would throw a argument out of range exception
                 */
                if (percentlife > 1)
                    percentlife = 1.0d;
            }

            Color col = Color.FromArgb(255 - ((int)(percentlife * 255)), this._color);

            //TODO might want to paint different shapes, but circles are funny, so it remains for the time being (and will most likely not change ;P)
            g.DrawEllipse(new Pen(col), this._x - 2, this._y - 2, 4, 4);
        }

    }
}
