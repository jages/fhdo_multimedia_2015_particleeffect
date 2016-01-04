using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParticleTest
{
    public class ParticleState
    {
        public Particle[] particles;
        public int particlecount;

        public ParticleState()
        {
            particlecount = 0;
            particles = new Particle[5120];
            particles[0] = new Particle(0f,0f, 1, 0f, 0f, System.Drawing.Color.Red);
        }

        public void addparticle(Particle p)
        {
            particles[particlecount] = p;
            particlecount++;
        }

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
