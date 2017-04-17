using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrawlMovie
{
    public class DBModel
    {
        public int r { get; set; }
        public Res res { get; set; }
        public Status status { get; set; }
    }

    public class Res
    {
        public string TYPE { get; set; }
        public int comment_count { get; set; }
        public int id { get; set; }
        public int kind { get; set; }
        public string kind_cn { get; set; }
        public string kind_str { get; set; }
        public int page_id { get; set; }
        public Payload payload { get; set; }
        public int status { get; set; }
        public Subject subject { get; set; }
        public Subject1[] subjects { get; set; }
        public User user { get; set; }
    }

    public class Payload
    {
        public string background_color { get; set; }
        public string background_img { get; set; }
        public string description { get; set; }
        public string has_barrage { get; set; }
        public string left { get; set; }
        public string mobile_background_img { get; set; }
        public string subject_ids { get; set; }
        public string title { get; set; }
        public string user_id { get; set; }
    }

    public class Subject
    {
        public string cover { get; set; }
        public string[] directors { get; set; }
        public string id { get; set; }
        public bool is_released { get; set; }
        public string m_url { get; set; }
        public string orig_title { get; set; }
        public float rating { get; set; }
        public int rating_count { get; set; }
        public string title { get; set; }
        public string type { get; set; }
        public string url { get; set; }
    }

    public class User
    {
        public string avatar { get; set; }
        public string id { get; set; }
        public string name { get; set; }
        public string url { get; set; }
    }

    public class Subject1
    {
        public string cover { get; set; }
        public string id { get; set; }
        public bool is_released { get; set; }
        public string m_url { get; set; }
        public string orig_title { get; set; }
        public float rating { get; set; }
        public int rating_count { get; set; }
        public string title { get; set; }
        public string type { get; set; }
        public string url { get; set; }
    }

    public class Status
    {
        public int code { get; set; }
    } 
}
