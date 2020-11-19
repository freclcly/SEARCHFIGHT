using SEARCHFIGHT.Core.Implement;
using SEARCHFIGHT.Core.Interfaces;
using SEARCHFIGHT.Core.Models;
using SEARCHFIGHT.Service.Implement;
using SEARCHFIGHT.Service.Interfaces;
using SEARCHFIGHT.Service.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SEARCHFIGHT.Service
{
    public static class SearchFightKernel
    {
        #region Attributes

        public static List<string> Reports { get; private set; }

        #endregion

        #region Services

        static ISearchManager SearchManager;
        static IWinnerManager WinnerManager;
        static IReportManager ReportManager;

        #endregion

        #region Constructors

        static SearchFightKernel()
        {
            // Initialize all our service dependencies
            SearchManager = new SearchManager();
            WinnerManager = new WinnerManager();
            ReportManager = new ReportManager();

            // Initialize our results attribute
            Reports = new List<string>();
        }

        #endregion

        #region Public Methods

        public static async Task ExecuteSearchFight(IList<string> terms)
        {
            IList<Search> searchData = await SearchManager.GetSearchResults(terms);
            IEnumerable<SearchEngineWinner> searchEngineWinners = WinnerManager.GetSearchEngineWinners(searchData);
            SearchEngineWinner grandWinner = WinnerManager.GetGrandWinner(searchData);

            Reports.AddRange(ReportManager.GetSearchResultsReport(searchData));
            Reports.AddRange(ReportManager.GetWinnersReport(searchEngineWinners));
            Reports.Add(ReportManager.GetGrandWinnerReport(grandWinner));
        }

        #endregion
    }
}
