namespace DesertGameThon.Model.Entites
{
    public class Anomaly
    {
        public int EffectiveRadius { get; set; }
        public int Id { get; set; }
        public int Radius { get; set; }
        public int Strenght { get; set; }
        public Velocity Velocity { get; set; }
        public int X { get; set; }
        public int Y { get; set; }
    }
}
