using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Planet_Personal_Investigation
{
    public class Planet
    {
        public double mass { get; set; }
        public double positionX { get; set; }
        public double positionY { get; set; }
        public double startPositionX { get; set; }
        public double startPositionY { get; set; }
        public double velocityX { get; set; }
        public double velocityY { get; set; }
        public double startVelocityX { get; set; }
        public double startVelocityY { get; set; }
        public int radius { get; set; }
        public Brush colour { get; set; }
        public bool centrePlanet { get; set; }
        public int scale { get; set; }
        public List<Point> previousPositions { get; set; }
        public int maxPreviousPositions { get; set; }
        public Pen pen { get; set; }
        public bool measured { get; set; }

        public Planet()
        {
            mass = 1;
            positionX = 0;
            positionY = 0;
            velocityX = 0;
            velocityY = 0;
            radius = 5;
            colour = Brushes.Red;
            pen = Pens.Red;
            previousPositions = new List<Point>();
            maxPreviousPositions = 100;
            measured = false;
        }

        public void SetColour()
        {
            colour = new SolidBrush(Color.FromArgb(255, (byte)(Math.Log(mass, 2.0d)) * 20, 255, 255));
            pen = new Pen(Color.FromArgb(255, (byte)(Math.Log(mass, 2.0d)) * 20, 255, 255));
        }

        public void Draw(object sender, PaintEventArgs e, int centrePositionX, int centrePositionY)
        {
            for (int i = 0; i < previousPositions.Count - 1; i++)
            {
                e.Graphics.DrawLine(pen, centrePositionX - previousPositions[i].X/scale, centrePositionY - previousPositions[i].Y/scale, centrePositionX - previousPositions[i + 1].X/scale, centrePositionY - previousPositions[i + 1].Y/scale);
            }
            e.Graphics.FillEllipse(colour, new RectangleF(centrePositionX - (int)(positionX/scale) - radius, centrePositionY - (int)(positionY/scale) - radius, 2 * radius, 2 * radius));
        }

        public void UpdatePosition(double fps, double time_per_second)
        {
            previousPositions.Add(new Point((int)positionX, (int)positionY));
            if (previousPositions.Count() > maxPreviousPositions) previousPositions.RemoveAt(0);
            positionX += velocityX * (1 / fps) * time_per_second;
            positionY += velocityY * (1 / fps) * time_per_second;
        }

        public void ApplyGravity(List<Planet> planets, double fps, double timePerSecond)
        {
            double G = 6.67430;

            foreach (Planet planet in planets)
            {
                if (planet.mass == -1) continue;
                double distanceX = Math.Abs(positionX - planet.positionX);
                double distanceY = Math.Abs(positionY - planet.positionY);

                if (distanceX == 0) continue;
                if (distanceY == 0) continue;

                double distanceSquared = (distanceX * distanceX) + (distanceY * distanceY);
                double acceleration = ((G * planet.mass) / distanceSquared);

                double componentX = Math.Atan(distanceX / distanceY) * acceleration;
                double componentY = Math.Atan(distanceY / distanceX) * acceleration;

                if (positionX > planet.positionX) componentX = -componentX;
                if (positionY > planet.positionY) componentY = -componentY;

                velocityX += componentX * (1/fps) * timePerSecond;
                velocityY += componentY * (1/fps) * timePerSecond;
            }
        }
    }
}
