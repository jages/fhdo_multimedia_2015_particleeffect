using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParticleTest
{
    /// <summary>
    /// Statemanager for particles. also handles removal and addition of particles, arbitrary limit to max particles can be set.
    /// </summary>
    public class ParticleState
    {
        public Particle[] particles;
        public int particlecount;
        public int particlelimit;

        /// <summary>
        /// creates instance of particle state manager
        /// </summary>
        public ParticleState()
        {
            particlecount = 0;
            particlelimit = 5119;
            particles = new Particle[5120];
            //particles[0] = new Particle(0f,0f, 1, 0f, 0f, System.Drawing.Color.Red);
            //depricated, was needed to not have a NullReferenceException in creation of draw thread. Should be solved?
        }

        /// <summary>
        /// Adds specified particle to particle management - every particle over limit will just not be added.
        /// </summary>
        /// <param name="p">Particle that should be added</param>
        public void addparticle(Particle p)
        {
            if (particlecount < particlelimit)
            {
                particles[particlecount] = p;
                particlecount++;
            }
        
        }

        /// <summary>
        /// removes particle with specified index by swapping dead particle with last living particle.
        /// Last particle in array needs special treatment
        /// </summary>
        /// <param name="i">index of particle to be removed</param>
        public void removeparticle(int i)
        {
            if (particles[i] != null && i < particlecount - 1)
            {
                particles[i] = particles[particlecount - 1];
                particlecount--;
            }
            else if ( i == particlecount-1)
            {
                particles[i] = null;
                particlecount--;
            }

        }
    }
}
