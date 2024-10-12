namespace DesertGameThon.Model.Entites
{
    public class Anomaly
    {
        public double EffectiveRadius { get; set; }
        public string Id { get; set; }
        public double Radius { get; set; }
        public int Strenght { get; set; }
        public Velocity Velocity { get; set; }
        public int X { get; set; }
        public int Y { get; set; }
    }
}
