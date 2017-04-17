using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;

namespace CrawlMovie
{
    public class ShowimgCrewl
    {
        static System.Web.Caching.Cache cache = System.Web.HttpRuntime.Cache;
        /// <summary>
        /// 正在上映
        /// </summary>
        /// <returns></returns>
        public static Rootobject GetShowingMovieInforListByCache()
        {
            string key = "SHOWING_LIST";
            if (cache[key] != null)
            {
                return cache[key] as Rootobject;
            }
            else
            {
                Rootobject model = GetMovieInfor(HtmlHelper.Showing);
                if (model == null)
                    return null;
                cache.Insert(key, model, null, DateTime.Now.AddDays(1), TimeSpan.Zero); ;
                return model;
            }
        }
        /// <summary>
        /// 即将上映
        /// </summary>
        /// <returns></returns>
        public static Rootobject GetComingMovieInforListByCache()
        {
            string key = "COMING_LIST";
            if (cache[key] != null)
            {
                return cache[key] as Rootobject;
            }
            else
            {
                Rootobject model = GetMovieInfor(HtmlHelper.Coming);
                if (model == null)
                    return null;
                cache.Insert(key, model, null, DateTime.Now.AddDays(1), TimeSpan.Zero); ;
                return model;
            }
        }
        /// <summary>
        /// Top250
        /// </summary>
        /// <returns></returns>
        public static Rootobject GetTopMovieInforListByCache()
        {
            string key = "TOP_LIST";
            if (cache[key] != null)
            {
                return cache[key] as Rootobject;
            }
            else
            {
                Rootobject model = GetMovieInfor(HtmlHelper.Top);
                if (model == null)
                    return null;
                cache.Insert(key, model, null, DateTime.Now.AddDays(1), TimeSpan.Zero); ;
                return model;
            }
        }
        public static Rootobject GetMovieInfor(string url)
        {
            Rootobject model = null;
            string html = HtmlHelper.LoadPageContent(url);
            if (!string.IsNullOrEmpty(html))
            {
                JavaScriptSerializer Serializer = new JavaScriptSerializer();
                model = Serializer.Deserialize<Rootobject>(html);
            }
            return model;
        }
    }
}
