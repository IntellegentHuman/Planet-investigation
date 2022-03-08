using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Planet_Personal_Investigation
{
    public class PlanetManager
    {
        public List<Planet> planets { get; set; }
        public Planet centrePlanet { get; set; }
        public double timePassed { get; set; }
        public StringBuilder excelString { get; set; }

        public PlanetManager(string _excelPath)
        {
            planets = new List<Planet>();
            excelString = new StringBuilder();
        }

        public void AddPlanet(Planet planet)
        {
            planet.scale = 1;
            planet.colour = new SolidBrush(Color.FromArgb(255, (byte)(Math.Log(planet.mass, 2.0d)) * 10, 255, 255-(byte)(Math.Log(planet.mass, 2.0d)) * 10));
            planet.startPositionX = planet.positionX;
            planet.startPositionY = planet.positionY;
            planet.startVelocityX = planet.velocityX;
            planet.startVelocityY = planet.velocityY;
            planets.Add(planet);
        }

        public void AddPlanet(double mass, double positionX, double positionY, double velocityX, double velocityY, int radius, Brush colour)
        {
            Planet planet = new Planet();
            planet.mass = mass;
            planet.positionX = positionX;
            planet.positionY = positionY;
            planet.velocityX = velocityX;
            planet.velocityY = velocityY;
            planet.radius = radius;
            planet.colour = colour;
            AddPlanet(planet);
        }

        public void AddPlanet(string s)
        {
            Planet planet = new Planet();
            string[] initializers = s.Split('\n');
            foreach (string init in initializers)
            {
                if (init == "\r" || init == "") continue;
                string[] parts = init.Split('=');
                string variable = parts[0];
                int value = Int32.Parse(parts[1]);
                if (variable == "mass") planet.mass = value;
                else if (variable == "positionX") planet.positionX = value;
                else if (variable == "positionY") planet.positionY = value;
                else if (variable == "velocityX") planet.velocityX = value;
                else if (variable == "velocityY") planet.velocityY = value;
                else if (variable == "radius") planet.radius = value;
                else if (variable == "centrePlanet" && value == 1)
                {
                    centrePlanet = planet;
                    planet.centrePlanet = true;
                    planet.colour = Brushes.Yellow;
                }
            }
            AddPlanet(planet);
        }

        public void Update(double fps, double time_per_second)
        {
            foreach (Planet planet in planets)
                planet.ApplyGravity(planets, fps, time_per_second);
            foreach (Planet planet in planets)
                planet.UpdatePosition(fps, time_per_second);
            timePassed += (1 / fps) * time_per_second;
            if (timePassed > 1)
            {
                
                for (int i = 0; i < planets.Count(); i++)
                {
                    if (Math.Abs(planets[i].startPositionX - planets[i].positionX) < 1 && !planets[i].measured)
                    {
                        excelString.AppendLine(string.Format("{0}, {1}, {2}, {3}, {4}", planets[i].startPositionX, planets[i].startPositionY, planets[i].startVelocityX, planets[i].startVelocityY, timePassed));
                        planets[i].measured = true;
                    }
                }
            }
        }

        public void Draw(object sender, PaintEventArgs e, int center_positionX, int center_positionY)
        {
            foreach (Planet planet in planets) planet.Draw(sender, e, center_positionX, center_positionY);
        }

        public void ReadFromFile(string path)
        {
            string text = System.IO.File.ReadAllText(path);
            string[] planet_strings = text.Split('#');
            foreach (string s in planet_strings) AddPlanet(s);
        }

        public void WriteToExcel(string path)
        {
            File.WriteAllText(path, excelString.ToString());
        }

        public void WriteToFile(string path)
        {
            using (StreamWriter file = new StreamWriter(path))
            {
                int i = 0;
                foreach(Planet planet in planets)
                {
                    file.WriteLine("mass=" + (int)planet.mass);
                    file.WriteLine("positionX=" + (int)planet.positionX);
                    file.WriteLine("positionY=" + (int)planet.positionY);
                    file.WriteLine("velocityX=" + (int)planet.velocityX);
                    file.WriteLine("velocityY=" + (int)planet.velocityY);
                    file.WriteLine("radius=" + (int)planet.radius);
                    file.WriteLine("centrePlanet=" + (planet.centrePlanet ? 1 : 0));
                    if (i != planets.Count()-1)file.WriteLine("\n#\n");
                    i++;
                }
            }
        }

        public void decreaseScale()
        {
            foreach (Planet planet in planets)
            {
                planet.scale--;
            }
        }
        public void increaseScale()
        {
            foreach (Planet planet in planets)
            {
                planet.scale++;
            }
        }
    }
}