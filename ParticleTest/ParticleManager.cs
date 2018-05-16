using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading;

namespace ParticleTest
{
    /// <summary>
    /// Statemanager for particles. also handles removal and addition of particles, arbitrary limit to max particles can be set.
    /// </summary>
    public class ParticleManager
    {
        private readonly Particle[] _particles;
        private int _particleCount;
        private readonly int _particleLimit;

        private const int ParticleLimitDefault = 5119;
        private const int ParticleStorageLimitDefault = 10240;

        /// <summary>
        /// creates instance of particle manager with default Particle Limits
        /// </summary>
        public ParticleManager() : this(ParticleLimitDefault, ParticleStorageLimitDefault)
        {
        }
        
        /// <summary>
        /// create instance of particle manager
        /// </summary>
        /// <param name="ParticleLimit">soft limit of living particles</param>
        /// <param name="ParticleStorageLimit">hard limit for number of particles, holds alive and dead particles before cleanup</param>
        public ParticleManager(int ParticleLimit, int ParticleStorageLimit)
        {
            _particleCount = 0;
            _particleLimit = ParticleLimit;
            _particles = new Particle[ParticleStorageLimit];
        }

        /// <summary>
        /// Adds specified particle to particle management - every particle over limit will just not be added.
        /// </summary>
        /// <param name="p">Particle that should be added</param>
        public void AddParticle(Particle p)
        {
            if (_particleCount < _particleLimit)
            {
                _particles[_particleCount] = p;
                _particleCount++;
            }
        }

        /// <summary>
        /// removes particle with specified index by swapping dead particle with last living particle.
        /// Last particle in array needs special treatment
        /// </summary>
        /// <param name="i">index of particle to be removed</param>
        private void RemoveParticle(int i)
        {
            if (_particles[i] != null && i < _particleCount - 1)
            {
                _particles[i] = _particles[_particleCount - 1];
                _particleCount--;
            }
            else if (i == _particleCount - 1)
            {
                _particles[i] = null;
                _particleCount--;
            }
        }

        public void UpdateParticles()
        {
            LinkedList<int> remove = new LinkedList<int>();
            for (int i = 0; i < _particleCount - 1; i++)
            {
                if (_particles[i].UpdateLifeState())
                    remove.AddLast(i);
            }

            foreach (int i in remove)
            {
                RemoveParticle(i);
            }
        }

        public void DrawParticles(Graphics canvas)
        {
            for (int i = _particleCount - 1; i > -1; i--)
            {
                _particles[i].Draw(canvas);
            }
        }
        
        
    }
}