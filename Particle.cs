using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabAlg
{
    public class Particle
    {
        public static Random rnd = new Random();
        static int rd=20, rD=30, nr=30, radius=3;
        public PointF location;
        public bool isD;
        public Particle(int wMax, int hMax) 
        {
            isD = false;
            location = new PointF(rnd.Next(wMax), rnd.Next(hMax));
        }

        public Particle()
        {
            isD=false;
        }

        public void Draw(Graphics handler) 
        {
            handler.DrawEllipse(Pens.Black, location.X - 3, location.Y - 3, 7, 7); 
        }

        
        public PointF spawnPoint()
        {
            float a = (float)(rnd.NextDouble() * Math.PI * 2);
            float t = (rnd.Next(radius));
            float x = location.X + (float)(t * Math.Cos(a));
            float y = location.Y + (float)(t * Math.Sin(a));
            return new PointF(x, y);


        }
        public List<Particle> Tick()
        {
            List<Particle> toR = new List<Particle>();
            int x = rnd.Next(100);

            if (x < rD)
            {
                int t = rnd.Next(nr + 1);

                for (int i = 0; i < t; i++)
                {
                    Particle local = new Particle();
                    local.location = spawnPoint();
                    toR.Add(local);
                }
            }
            if (x < rd)
            {
                this.isD = true;
            }
            return toR;
            
        }
    }
}
