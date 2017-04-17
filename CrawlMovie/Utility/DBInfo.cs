using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HtmlAgilityPack;
using System.Web.Script.Serialization;

namespace CrawlMovie
{
    public class DBInfo
    {
        static System.Web.Caching.Cache cache = System.Web.HttpRuntime.Cache;
        /// <summary>
        /// 2016评分最高电影
        /// </summary>
        /// <returns></returns>
        public static DBModel GetMovieInforListByCache(string key,int i)
        { 
            if (cache[key] != null)
            {
                return cache[key] as DBModel;
            }
            else
            {
                DBModel model = GetMovieInfor("https://movie.douban.com/ithil_j/activity/movie_annual2016/widget/"+i);
                if (model == null)
                    return null;
                cache.Insert(key, model, null, DateTime.Now.AddDays(1), TimeSpan.Zero); ;
                return model;
            }
        } 
        public static DBModel GetMovieInfor(string url)
        {
            DBModel model = null; 
            string html = HtmlHelper.LoadPageContent(url);
            if (!string.IsNullOrEmpty(html))
            {
                JavaScriptSerializer Serializer = new JavaScriptSerializer();
                model = Serializer.Deserialize<DBModel>(html);  
            }
            return model;
        }
    }
}
