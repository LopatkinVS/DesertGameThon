using DesertGameThon.Model.Entites;

namespace DesertGameThon.Model
{
    public class GameStateResponse
    {
        public MapSize MapSize { get; set; }
        public string Name { get; set; }
        public int Points {  get; set; }
        public List<Anomaly> Anomalies { get; set; }
        public List<Transport> Transports { get; set; }
        public List<Enemy> Enemies { get; set; }
        public List<Enemy> WantedList { get; set; }
        public List<Bounty> Bounties { get; set; }
        public double MaxSpeed { get; set; }
        public double MaxAccel { get; set; }
        public double AttackRange { get; set;}
        public int AttackCooldownMs { get; set; }
        public int AttackDamage {  get; set; }
        public double AttackExplosionRadius {  get; set; }
        public int ReviveTimeoutSec { get; set; }
        public int ShieldTimeMs { get; set; }
        public int ShieldCooldownMs { get; set; }
        public int TransportRadius { get; set; }
        public List<Errors> Errors { get; set; }
    }
}
