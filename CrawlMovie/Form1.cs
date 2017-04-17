using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CrawlMovie
{
    public partial class Form1 : Form
    {
        //观看地址
        static string gkUrl = string.Empty;
        public Form1()
        {
            InitializeComponent();
            cmb_type.SelectedIndex = 0;
            com_orderby.SelectedIndex = 0;
            pic_img.ImageLocation = "http://ojtdqq2ha.bkt.clouddn.com/16b0b3789293bd7ba4e280a228546ef3.jpg";
            pic_img.SizeMode = PictureBoxSizeMode.StretchImage;//是图片的大小适应控件PictureBox的大小  
        } 
        /// <summary>
        /// 2016信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmb_type_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cmb_type.SelectedIndex)
            {
                case 1:
                    GetMovieList("DBHY_LIST", 1);
                    break;
                case 2:
                    GetMovieList("DBWY_LIST", 2);
                    break;
                case 3:
                    GetMovieList("DBZSGZY_LIST", 4);
                    break;
                case 4:
                    GetMovieList("DBZSGZFY_LIST", 5);
                    break;
                case 5:
                    GetMovieList("DBDLDL_LIST", 7);
                    break;
                case 6:
                    GetMovieList("DBLMJP_LIST", 8);
                    break;
                case 7:
                    GetMovieList("DBHG_LIST", 10);
                    break;
                case 8:
                    GetMovieList("DBWRB_LIST", 11);
                    break;
                case 9:
                    GetMovieList("DBOZ_LIST", 12);
                    break;
                case 10:
                    GetMovieList("DBTXL_LIST", 13);
                    break;
                case 11:
                    GetMovieList("DBXJ_LIST", 15);
                    break;
                case 12:
                    GetMovieList("DBAQ_LIST", 16);
                    break;
                case 13:
                    GetMovieList("DBKH_LIST", 17);
                    break;
                case 14:
                    GetMovieList("DBKB_LIST", 18);
                    break;
                case 15:
                    GetMovieList("DBDH_LIST", 20);
                    break;
                case 16:
                    GetMovieList("DBJLP_LIST", 21);
                    break;
                case 17:
                    GetMovieList("DBDP_LIST", 22);
                    break;
                case 18:
                    GetMovieList("DBDLDSJ_LIST", 24);
                    break;
                case 19:
                    GetMovieList("DBYMJ_LIST", 25);
                    break;
                case 20:
                    GetMovieList("DBYMJF_LIST", 26);
                    break;
                case 21:
                    GetMovieList("DBHJ_LIST", 28);
                    break;
                case 22:
                    GetMovieList("DBRJ_LIST", 29);
                    break;
                case 23:
                    GetMovieList("DBQITJ_LIST", 30);
                    break;
                case 24:
                    GetMovieList("DBDHJJ_LIST", 34);
                    break;
                case 25:
                    GetMovieList("DBJLJJ_LIST", 35);
                    break;
                case 26:
                    GetMovieList("DB1YRM_LIST", 41);
                    break;
                case 27:
                    GetMovieList("DB2yrm_LIST",42);
                    break;
                case 28:
                    GetMovieList("DB3YRM_LIST", 43);
                    break;
                case 29:
                    GetMovieList("DB4YRM_LIST", 45);
                    break;
                case 30:
                    GetMovieList("DB5YRM_LIST", 46);
                    break;
                case 31:
                    GetMovieList("DB6YRM_LIST", 47);
                    break;
                case 32:
                    GetMovieList("DB7YRM_LIST",49);
                    break;
                case 33:
                    GetMovieList("DB8YRM_LIST", 50);
                    break;
                case 34:
                    GetMovieList("DB9YRM_LIST", 51);
                    break;
                case 35:
                    GetMovieList("DB10YRM_LIST", 53);
                    break;
                case 36:
                    GetMovieList("DB11YRM_LIST", 54);
                    break;
                case 37:
                    GetMovieList("DB12YRM_LIST", 55);
                    break;
                case 38:
                    GetMovieList("DB10ZN_LIST", 57);
                    break;
                case 39:
                    GetMovieList("DB20ZN_LIST", 58);
                    break;
                case 40:
                    GetMovieList("DB30ZN_LIST", 59);
                    break;
                case 41:
                    GetMovieList("DBqdhy_LIST", 68);
                    break;
                case 42:
                    GetMovieList("DBqdwy_LIST", 69);
                    break;
                case 43:
                    GetMovieList("DBbj_LIST", 70);
                    break; 
                default:
                    break;
            } 
        }
        private void GetMovieList(string key,int i)
        {
            DBModel model = DBInfo.GetMovieInforListByCache(key, i);
            if (model!= null)
            {
                lisb_movie.Items.Clear();
                foreach (Subject1 item in model.res.subjects)
                {
                    lisb_movie.Items.Add(item.title + "-" + item.rating + "分");
                }
            }
        }

        private void lisb_movie_SelectedIndexChanged(object sender, EventArgs e)
        {
            //电影名
            string movieName = lisb_movie.SelectedItem.ToString().Split('-')[0];
            GetMovieInfo(movieName.TrimEnd('。'));
        } 
        /// <summary>
        /// 查找电影
        /// </summary>
        /// <param name="movieName"></param>
        public void GetMovieInfo(string movieName)
        { 
            txt_name.Text = movieName;
            rtb_xping.Text = "";
            pic_img.ImageLocation = "http://ojtdqq2ha.bkt.clouddn.com/16b0b3789293bd7ba4e280a228546ef3.jpg";
            gkUrl = "";  
            btn_search.Enabled = false;
            //try
            //{
                IDModel movieInfo = ID97Crewl.GetMovieInforMode(movieName);
                IDModel wxMovie = WXCrewl.GetMovieInfor(movieName);
                if (movieInfo != null && movieInfo.downURL != null)
                {
                    rtb_messagebox.Text = movieInfo.downURL;
                    rtb_xping.Text = movieInfo.inforMessage;
                    pic_img.ImageLocation = movieInfo.headImg;
                    if (wxMovie != null && wxMovie.downURL != null)
                    {
                        gkUrl = wxMovie.downURL;
                    }
                }
                else
                {
                    if (wxMovie != null && wxMovie.downURL != null)
                    {
                        rtb_messagebox.Text = "无下载资源，点击在线观看！";
                        rtb_xping.Text = wxMovie.inforMessage;
                        pic_img.ImageLocation = wxMovie.headImg;
                        gkUrl = wxMovie.downURL;
                    }
                    else
                    {
                        rtb_xping.Text = "";
                        pic_img.ImageLocation = "http://ojtdqq2ha.bkt.clouddn.com/16b0b3789293bd7ba4e280a228546ef3.jpg";
                        gkUrl = "";
                        rtb_messagebox.Text = "暂无资源！";
                    }
                }
            //}
            //catch (Exception)
            //{ 
            //    throw;
            //}
            
            btn_search.Enabled = true;
        }
        /// <summary>
        /// 点击搜索
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_search_Click(object sender, EventArgs e)
        {
            rtb_messagebox.Text = ""; 
            if (txt_name.Text.Trim() == "")
            {
                btn_search.Enabled = true;
                rtb_messagebox.Text = "请输入要查找的电影名称！";
                return;
            }
            GetMovieInfo(txt_name.Text.Trim());
        }
        /// <summary>
        /// 点击观看
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_look_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(gkUrl))
            {
                //调用IE浏览器    
                //System.Diagnostics.Process.Start("iexplore.exe", "http://blog.csdn.net/testcs_dn");

                System.Diagnostics.Process process = new System.Diagnostics.Process();

                process.StartInfo.FileName = "iexplore.exe";   //IE浏览器，可以更换

                process.StartInfo.Arguments = gkUrl;

                process.Start();
            }
            else
            {
                MessageBox.Show("暂无播放资源，可以尝试复制下载资源到迅雷，边看边下！");
            }
        }

        private void com_orderby_SelectedIndexChanged(object sender, EventArgs e)
        { 
            switch (com_orderby.SelectedIndex)
            {
                case 1:
                    ShowShowing();
                    break;
                case 2:
                    ShowComing();
                    break;
                case 3:
                    ShowTop();
                    break;
            }
        }
        /// <summary>
        /// 展示正在上影
        /// </summary>
        public void ShowShowing()
        {
            Rootobject model = ShowimgCrewl.GetShowingMovieInforListByCache();
            if (model != null)
            {
                lisb_orderby.Items.Clear(); 
                foreach (Subjects item in model.subjects)
                {
                    lisb_orderby.Items.Add(item.title + "-" + item.rating.average + "分");
                }
            }
        }
        /// <summary>
        /// 即将上映
        /// </summary>
        public void ShowComing()
        {
            Rootobject model = ShowimgCrewl.GetComingMovieInforListByCache();
            if (model != null)
            {
                lisb_orderby.Items.Clear();
                foreach (Subjects item in model.subjects)
                {
                    lisb_orderby.Items.Add(item.title + "-" + item.rating.average + "分");
                }
            }
        }
        /// <summary>
        /// Top250
        /// </summary>
        public void ShowTop()
        {
            Rootobject model = ShowimgCrewl.GetTopMovieInforListByCache();
            if (model != null)
            {
                lisb_orderby.Items.Clear();
                foreach (Subjects item in model.subjects)
                {
                    lisb_orderby.Items.Add(item.title + "-" + item.rating.average + "分");
                }
            }
        } 
        private void lisb_orderby_SelectedIndexChanged(object sender, EventArgs e)
        {
            //电影名
            string movieName = lisb_orderby.SelectedItem.ToString().Split('-')[0];
            GetMovieInfo(movieName.TrimEnd('。'));
        }

    }
}
