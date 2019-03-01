using GiphyService.Libs.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace GiphyService.Libs.Giphy
{
    public class GetRandomGif : IGetRandomGif
    {
        public async Task<GiphyModel> ReturnRandomGifBasedOnTag(string searchCriteria)
        {
            const string giphyKey = "jUoTdMpjs7ohnvwZbxvhzzhpQd7klUK7"; //TODO : set up in separate config...

            using (var client = new HttpClient())
            {
                var url = new Uri($"http://api.giphy.com/v1/gifs/search?q={searchCriteria}&api_key={giphyKey}"); //TODO : investigate if parsing separate words into own tags from search criteria is better for results

                var response = await client.GetAsync(url);

                string json;

                using (var content = response.Content)
                {
                    json = await content.ReadAsStringAsync();
                }

                return JsonConvert.DeserializeObject<GiphyModel>(json);
            }
        }
    }
}
