namespace DesertGameThon.Model.EntitesPost
{
    public class TransportPost
    {
        public VelocityPost Acceleration { get; set; }
        public bool ActiveShield { get; set; }
        public Coordinates Attack {  get; set; }
        public string Id { get; set; }

        public TransportPost()
        {
            Acceleration = new VelocityPost();
            Attack = new Coordinates();
        }
    }
}
