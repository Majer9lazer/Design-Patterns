using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.BuilderPattern
{
    class WoodyHomeBuilder : HomeBuilder
    {
        private Random _rnd = new Random();
        public override void BuildHome()
        {
            this.home.Name = "Деревянный дом";
            this.home.Groundwork = new Groundwork()
            {
                Height = 1.476,
                Material = new TypeOfMaterial
                { Name = "Бетон", Price = 500.4 },
                Name = "Это фундамент",
                Width = 452.5
            };
            this.home.Roof = new Roof
            {
                Name = "Это крыша",
                Height = 2.0,
                Width = 450.4,
                Material = new TypeOfMaterial
                {
                    Name = "Металло черепица",
                    Price = 111
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
                        Name = "Дерево",
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
