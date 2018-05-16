using System;
using System.Drawing;

namespace ParticleTest
{
    public class Particle
    {
        private float _xPosition;
        private float _yPosition;

        private float _velocityX;
        private float _velocityY;

        private readonly float _gravityX;
        private readonly float _gravityY;

        private readonly TimeSpan _life;
        private readonly DateTime _birth;

        private readonly Color _color;

        private readonly bool _hasDecay;

        

        /// <summary>
        /// Creates a particle
        /// </summary>
        /// <param name="xPosition">starting position horizontal</param>
        /// <param name="yPosition">starting position vertical</param>
        /// <param name="gravityX">'windeffect' - 'pull' towards horizontal infinity, negative values for 'push'</param>
        /// <param name="gravityY">'gravityeffect' - 'pull' towards vertical infinity, negative values for 'push'</param>
        /// <param name="life">lifetime in seconds</param>
        /// <param name="angle">angle in degrees. 0 is straight left, 90 is straight down</param>
        /// <param name="speed">speed in pixels per update</param>
        /// <param name="color">color of particle</param>
        /// <param name="hasDecay">if true, will fade based on % of lifetime left. - only affects alpha of color in draw</param>
        public Particle(float xPosition, float yPosition,float gravityX, float gravityY, int life, float angle, float speed, Color color, bool hasDecay)
        {
            //set default values for movement and behavior
            _xPosition = xPosition;
            _yPosition = yPosition;
            _gravityX = gravityX;//default was 0.0f
            _gravityY = gravityY;//default was 0.05f
            _hasDecay = hasDecay;//default was true
            _color = color;
            
            //calculate movement direction from angle and speed into a velocity vector (easier to set in GUI)
            float angleRad = (float)(angle * Math.PI / 180); //convert angle in degrees to rad for x and y velocity
            _velocityX = (float)(speed * Math.Cos(angleRad));
            _velocityY = (float)(speed * Math.Sin(angleRad));

            //complete all calculations before 'birth'
            _birth = DateTime.Now;
            _life = new TimeSpan(0, 0, 0, life);

        }

        /// <summary>
        /// updates particle state
        /// </summary>
        /// <returns>returns true if particle is ready to die</returns>
        public bool UpdateLifeState()
        {
            bool isDepleted = (DateTime.Now - _birth > _life);

            if (!isDepleted)
            {
                //update particle position based on velocity
                _xPosition += _velocityX;
                _yPosition += _velocityY;

                //TODO need a more elegant solution to gravity / wind
                _velocityY += _gravityY;
                _velocityX += _gravityX;
            }

            return isDepleted;

        }

        /// <summary>
        /// draws particle onto graphics
        /// </summary>
        /// <param name="canvas">graphics object the particle is painted upon</param>
        public void Draw(Graphics canvas)
        {
            double percentLife = 0;//defult to 0, if no decay is set, alpha will always be set to 255
            if (_hasDecay)
            {
                double lifetimeTotal = _life.TotalMilliseconds;
                double lifetime = (DateTime.Now - _birth).TotalMilliseconds;
                /* due to asynchronos calls, a particle can outlive it's lifetime by a marginal amount
                 * following flattening of values will ensure that the alpha value can be set correctly, or it would throw a argument out of range exception
                 */
                percentLife = (lifetime > lifetimeTotal) ? 1 : (lifetime / lifetimeTotal); 
            }

            Color color = Color.FromArgb(255 - ((int)(percentLife * 255)), _color);

            //TODO might want to paint different shapes, but circles are funny, so it remains for the time being (and will most likely not change ;P)
            canvas.DrawEllipse(new Pen(color), _xPosition - 2, _yPosition - 2, 4, 4);
        }

       

    }
}
