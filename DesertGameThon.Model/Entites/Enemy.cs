namespace DesertGameThon.Model.Entites
{
    public class Enemy
    {
        public int Health { get; set; }
        public int KillBounty { get; set; }
        public int ShieldLeftMs { get; set; }
        public string Status { get; set; }
        public Velocity Velocity { get; set; }
        public int X { get; set; }
        public int Y { get; set; }
    }
}
