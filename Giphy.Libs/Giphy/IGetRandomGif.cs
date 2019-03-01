using GiphyService.Libs.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace GiphyService.Libs.Giphy
{
    public interface IGetRandomGif
    {
        Task<GiphyModel> ReturnRandomGifBasedOnTag(string searchCriteria);
    }
}
