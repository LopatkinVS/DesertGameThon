using DesertGameThon.Data.DataHelper;
using DesertGameThon.Model;
using DesertGameThon.Model.Entites;
using DesertGameThon.Model.EntitesPost;

namespace DesertGameThon.Data.Algorithm
{
    public class MoveToGold
    {
        private readonly FindGoldAndDiraction _findGoldAndDiraction;
        private readonly CountMaxSpeed _countMaxSpeed;

        public VelocityPost MoveTo(Transport transport, GameStateResponse gameStateResponse)
        {
             var coordinate = _findGoldAndDiraction.FindNearestGold(gameStateResponse, transport);
             return _countMaxSpeed.CalculateMaxAcceleration(transport, coordinate);
        }
    }
}
