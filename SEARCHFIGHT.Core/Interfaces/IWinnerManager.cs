﻿using SEARCHFIGHT.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEARCHFIGHT.Core.Interfaces
{
    public interface IWinnerManager
    {/// <summary>
     /// Get an enumerable with all the winners by engine.
     /// </summary>
     /// <param name="searchData">A list with al the search results.</param>
     /// <returns>An enumerable with winners by engine.</returns>
        IEnumerable<SearchEngineWinner> GetSearchEngineWinners(IList<Search> searchData);

        /// <summary>
        /// Get grand winner from all the search data.
        /// </summary>
        /// <param name="searchData">A list with al the search results.</param>
        /// <returns>The grand winner information.</returns>
        SearchEngineWinner GetGrandWinner(IList<Search> searchData);
    }
}
