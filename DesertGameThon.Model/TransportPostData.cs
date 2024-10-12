using DesertGameThon.Model.EntitesPost;

namespace DesertGameThon.Model
{
    public class TransportPostData
    {
        public List<TransportPost> Transports { get; set; }

        public TransportPostData()
        {
            Transports = new List<TransportPost>();

            for (int i = 0; i < 4; i++)
            {
                Transports.Add(new TransportPost());
            }
        }
    }
}
