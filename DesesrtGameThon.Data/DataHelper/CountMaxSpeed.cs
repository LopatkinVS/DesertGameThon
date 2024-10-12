using DesertGameThon.Model.Entites;
using DesertGameThon.Model.EntitesPost;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesertGameThon.Data.DataHelper
{
    public class CountMaxSpeed
    {
        public VelocityPost CalculateMaxAcceleration(Transport transport, Coordinates coordinate)
        {
            var acceleration = new VelocityPost();
            double deltaX = coordinate.X - transport.X;
            double deltaY = coordinate.Y - transport.Y;
            double vectorLenght = Math.Sqrt(deltaX * deltaX + deltaY * deltaY);

            if(vectorLenght > 10)
            {
                double scale = 10 / vectorLenght;
                deltaX *= scale;
                deltaY *= scale;
            }

            acceleration.X = deltaX;
            acceleration.Y = deltaY;

            return acceleration;
        }
    }
}
