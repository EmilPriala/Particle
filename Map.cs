using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabAlg
{
    public class Map
    {
        public List<Particle> particles;
        public int Width, Height;
        public Map()
        {
            particles = new List<Particle>();
        }
        public void Init(int n)
        {
            for (int i = 9; i < n; i++)
            {
                particles.Add(new Particle(Width, Height));
            }
        }
        public void Draw(Graphics handler)
        {
            foreach (Particle p in particles)
            {
                p.Draw(handler);
            }

        }
        public void Tick()
        {
            List<Particle> chl = new List<Particle>();
            foreach (Particle p in particles)
            {
                foreach (Particle part in p.Tick())
                {
                    chl.Add(part);
                }

            }
            particles = particles.FindAll(delegate (Particle A) { return !A.isD; });
            foreach (Particle p in chl)
            {
                if(p.location.X >= 0 && p.location.X< Width && p.location.Y >= 0 && p.location.Y < Height)
                particles.Add(p);
            }
        }

    }
}
