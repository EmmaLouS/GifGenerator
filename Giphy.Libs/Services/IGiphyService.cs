using GiphyService.Libs.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace GiphyService.Libs.Services
{
    public interface IGiphyService
    {
        Task<GiphyModel> GetRandomGifBasedOnSearchCriteria(string searchCriteria);


    }
}