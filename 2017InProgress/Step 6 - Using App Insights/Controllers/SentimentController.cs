using System.Collections.Generic;
using System.Configuration;
using System.Threading.Tasks;
using System.Web.Mvc;
using Step1WebApp.Models;
using Step1WebApp.Repositories;

namespace Step1WebApp.Controllers
{
    public class SentimentController : Controller
    {
        SentimentAnalysisRepository Repository { get; } =
            new SentimentAnalysisRepository(ConfigurationManager.AppSettings["DocumentDBUri"],
                                            ConfigurationManager.AppSettings["DocumentDBKey"]);


        public async Task<ActionResult> ViewSentimentAnalysis()
        {
            var results = await Repository.GetSentimentAnalysis();
            return View(results);
        }
    }
}