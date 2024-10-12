using DesertGameThon.Model.Entites;
using System.Runtime.ExceptionServices;

namespace DesertGameThon.Data.DataHelper
{
    public class CountHypotenuse
    {
        public double Hypotenuse(Transport transport, Bounty bounty)
        {
            var firstRolls = Math.Pow(bounty.X - transport.X, 2);
            var secondRolls = Math.Pow(bounty.Y - transport.Y, 2);

            return (Math.Sqrt(firstRolls + secondRolls));
        }
    }
}
