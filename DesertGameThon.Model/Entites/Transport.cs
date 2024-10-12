namespace DesertGameThon.Model.Entites
{
    public class Transport
    {
        public Velocity AnomalyAcceleration { get; set; }
        public int AttackCooldownMs { get; set; }
        public int DeathCount { get; set; }
        public int Health { get; set; }
        public string Id { get; set; }
        public Velocity SelfAcceleration { get; set; }
        public int ShieldCooldownMs { get; set; }
        public int ShieldLeftMs { get; set; }
        public string Status { get; set; }
        public Velocity Velocity { get; set; }
        public int X { get; set; }
        public int Y { get; set; }
    }
}
