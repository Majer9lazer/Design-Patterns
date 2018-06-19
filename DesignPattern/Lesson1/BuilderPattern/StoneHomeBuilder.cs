using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.BuilderPattern
{
    class StoneHomeBuilder : HomeBuilder
    {
        private Random _rnd = new Random();
        public override void BuildHome()
        {
            this.home.Name = "Каменный дом";

            this.home.Groundwork = new Groundwork()
            {
                Height = 1.476,
                Material = new TypeOfMaterial
                    { Name = "Бетон", Price = _rnd.NextDouble()*100 },
                Name = "Это фундамент",
                Width = _rnd.NextDouble()*1000
            };
            this.home.Roof = new Roof
            {
                Name = "Это крыша",
                Height = _rnd.NextDouble(),
                Width = _rnd.NextDouble(),
                Material = new TypeOfMaterial
                {
                    Name = "Металло черепица",
                    Price = _rnd.NextDouble()*1452
                }
            };
            for (int i = 0; i < this.home.Walls.Length; i++)
            {
                home.Walls[i] = new Wall()
                {
                    Width = _rnd.NextDouble(),
                    Height = _rnd.NextDouble(),
                    Material = new TypeOfMaterial()
                    {
                        Name = "Сталь",
                        Price = _rnd.NextDouble()
                    }
                };
            }
        }
        public override void ShowInfo()
        {
            home.ShowInfo();
        }


    }
}
