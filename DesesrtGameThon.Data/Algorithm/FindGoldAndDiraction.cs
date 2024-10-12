using DesertGameThon.Data.DataHelper;
using DesertGameThon.Model;
using DesertGameThon.Model.Entites;
using DesertGameThon.Model.EntitesPost;

namespace DesertGameThon.Data.Algorithm
{
    public class FindGoldAndDiraction
    {
        private readonly CountHypotenuse _countHypotenuse;

        public Coordinates FindNearestGold(GameStateResponse gameState, 
            Transport transport)
        {
            var bountyList = gameState.Bounties;
            double range = double.MaxValue;
            var nearestGold = new Coordinates();


            foreach (var bounty in bountyList)
            {
                var tempRange = _countHypotenuse.Hypotenuse(transport, bounty);

                if (tempRange < range)
                {
                    range = tempRange;
                    nearestGold.X = bounty.X;
                    nearestGold.Y = bounty.Y;
                }
            }

            return nearestGold;
        }
    }
}
