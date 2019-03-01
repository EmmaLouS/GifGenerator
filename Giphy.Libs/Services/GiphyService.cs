using GiphyService.Libs.Giphy;
using GiphyService.Libs.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace GiphyService.Libs.Services
{
    public class GiphyService : IGiphyService
    {
        private readonly IGetRandomGif _getRandomGif;

        public GiphyService(IGetRandomGif getRandomGif)
        {
            _getRandomGif = getRandomGif;
        }

        public async Task<GiphyModel> GetRandomGifBasedOnSearchCriteria(string searchCriteria)
        {
            return await _getRandomGif.ReturnRandomGifBasedOnTag(searchCriteria);
        }
    }
}
