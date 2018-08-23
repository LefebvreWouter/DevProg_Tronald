using System;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Tronald.Model
{
    public class TronaldManager
    {
        public async static Task<OverviewTag> GetTagsAsync()
        {
            using (HttpClient client = new HttpClient())
            {
                try
                {
                    client.DefaultRequestHeaders.Add("Accept", "application/json");
                    string url = string.Format("https://api.tronalddump.io/tag");
                    string json = await client.GetStringAsync(url);
                    if (json != null)
                        return JsonConvert.DeserializeObject<OverviewTag>(json);
                    return
                        null;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        public async static Task<Quote> GetQuoteOfTheDay()
        {
            using (HttpClient client = new HttpClient())
            {
                try
                {
                    client.DefaultRequestHeaders.Add("Accept", "application/json");
                    string url = string.Format("https://api.tronalddump.io/random/quote");
                    string json = await client.GetStringAsync(url);
                    if (json != null)
                        return JsonConvert.DeserializeObject<Quote>(json);
                    return
                        null;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        public async static Task<Quotes> GetQuotesByTag(string Tag)
        {
            using (HttpClient client = new HttpClient())
            {
                try
                {
                    client.DefaultRequestHeaders.Add("Accept", "application/json");
                    string url = string.Format("https://api.tronalddump.io/search/quote?query={0}", Tag);
                    string json = await client.GetStringAsync(url);
                    if (json != null)
                        return JsonConvert.DeserializeObject<Quotes>(json);
                    return
                        null;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }
    }
}
