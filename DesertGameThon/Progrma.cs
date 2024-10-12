using DesertGameThon.Data.Algorithm;
using DesertGameThon.Model;
using System;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace DesertGameThon
{
    public class Progrma
    {
        private static readonly HttpClient client = new HttpClient();
        private static readonly MoveToGold _moveToGold;

        public static async Task Main(string[] args)
        {
            string url = "https://games.datsteam.dev/play/magcarp/player/move";
            string apiKey = "6704413ebe86b6704413ebe86e";

            while (true)
            {
                GameStateResponse gameState = await SendEmptyPostRequest(url, apiKey);
                if (gameState != null)
                {
                    Console.WriteLine($"Player Name: {gameState.Name}, Points: {gameState.Points}");
                }

                TransportPostData transportPostData = new TransportPostData();
                foreach (var transports in gameState.Transports)
                {
                    foreach (var transport in transportPostData.Transports)
                    {
                        transport.Acceleration = _moveToGold.MoveTo(transports, gameState);
                    }
                }

                SendPostRequestWithData(url, apiKey, transportPostData);
            }
        }

        private static async Task<GameStateResponse> SendEmptyPostRequest(string url, string apiKey)
        {
            {
                client.DefaultRequestHeaders.Clear();
                client.DefaultRequestHeaders.Add("X-Auth-Token", apiKey);

                HttpResponseMessage response = await client.PostAsync(url, null);

                if (response.IsSuccessStatusCode)
                {
                    string jsonResponse = await response.Content.ReadAsStringAsync();

                    GameStateResponse gameState = JsonSerializer.Deserialize<GameStateResponse>(jsonResponse);
                    return gameState;
                }
                else
                {
                    Console.WriteLine("Error: " + response.StatusCode);
                    return null;
                }
            }
        }

        private static async Task<HttpResponseMessage> SendPostRequestWithData(string url, string apiKey, TransportPostData data)
        {
            string jsonData = JsonSerializer.Serialize(data);

            StringContent content = new StringContent(jsonData, Encoding.UTF8, "application/json");

            client.DefaultRequestHeaders.Clear();
            client.DefaultRequestHeaders.Add("X-Auth-Token", apiKey);

            HttpResponseMessage response = await client.PostAsync(url, content);
            return response;
        }
    }
}
