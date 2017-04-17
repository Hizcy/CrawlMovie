namespace CrawlMovie
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.cmb_type = new System.Windows.Forms.ComboBox();
            this.lisb_movie = new System.Windows.Forms.ListBox();
            this.com_orderby = new System.Windows.Forms.ComboBox();
            this.lisb_orderby = new System.Windows.Forms.ListBox();
            this.btn_look = new System.Windows.Forms.Button();
            this.btn_search = new System.Windows.Forms.Button();
            this.rtb_xping = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rtb_messagebox = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pic_img = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pic_img)).BeginInit();
            this.SuspendLayout();
            // 
            // cmb_type
            // 
            this.cmb_type.FormattingEnabled = true;
            this.cmb_type.Items.AddRange(new object[] {
            "--选择--",
            "2016评分最高的华语电影",
            "2016评分最高的外语电影",
            "2016最受关注的院线电影",
            "2016最受关注的非院线电影",
            "2016年度大陆独立佳作",
            "2016年度冷门佳片",
            "2016评分最高的韩国电影",
            "2016评分最高的日本电影",
            "2016评分最高的欧洲电影",
            "2016年度LGBT电影",
            "2016评分最高的喜剧片",
            "2016评分最高的爱情片",
            "2016评分最高的科幻/动作片",
            "2016评分最高的恐怖片",
            "2016评分最高的动画片",
            "2016评分最高的纪录片",
            "2016评分最高的短片",
            "2016评分最高的大陆电视剧",
            "2016评分最高的英美剧(新剧)",
            "2016评分最高的英美剧(非新剧)",
            "2016评分最高的韩剧",
            "2016评分最高的日剧",
            "2016评分最高的其它地区剧集 ",
            "2016评分最高的动画剧集",
            "2016评分最高的纪录剧集 ",
            "1月最热门电影",
            "2月最热门电影",
            "3月最热门电影",
            "4月最热门电影",
            "5月最热门电影",
            "6月最热门电影",
            "7月最热门电影",
            "8月最热门电影",
            "9月最热门电影",
            "10月最热门电影",
            "11月最热门电影",
            "12月最热门电影",
            "2016上映10周年的电影",
            "2016上映20周年的电影",
            "2016上映30周年的电影",
            "2017最值得期待的华语电影",
            "2017最值得期待的外语电影",
            "2016-2017北美颁奖季热门佳片"});
            this.cmb_type.Location = new System.Drawing.Point(12, 13);
            this.cmb_type.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmb_type.Name = "cmb_type";
            this.cmb_type.Size = new System.Drawing.Size(225, 28);
            this.cmb_type.TabIndex = 1;
            this.cmb_type.SelectedIndexChanged += new System.EventHandler(this.cmb_type_SelectedIndexChanged);
            // 
            // lisb_movie
            // 
            this.lisb_movie.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lisb_movie.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lisb_movie.FormattingEnabled = true;
            this.lisb_movie.ItemHeight = 20;
            this.lisb_movie.Location = new System.Drawing.Point(12, 48);
            this.lisb_movie.Name = "lisb_movie";
            this.lisb_movie.Size = new System.Drawing.Size(225, 404);
            this.lisb_movie.TabIndex = 2;
            this.lisb_movie.SelectedIndexChanged += new System.EventHandler(this.lisb_movie_SelectedIndexChanged);
            // 
            // com_orderby
            // 
            this.com_orderby.FormattingEnabled = true;
            this.com_orderby.Items.AddRange(new object[] {
            "--选择--",
            "正在热映",
            "即将上映",
            "TOP20"});
            this.com_orderby.Location = new System.Drawing.Point(922, 13);
            this.com_orderby.Name = "com_orderby";
            this.com_orderby.Size = new System.Drawing.Size(221, 28);
            this.com_orderby.TabIndex = 15;
            this.com_orderby.SelectedIndexChanged += new System.EventHandler(this.com_orderby_SelectedIndexChanged);
            // 
            // lisb_orderby
            // 
            this.lisb_orderby.FormattingEnabled = true;
            this.lisb_orderby.ItemHeight = 20;
            this.lisb_orderby.Location = new System.Drawing.Point(922, 48);
            this.lisb_orderby.Name = "lisb_orderby";
            this.lisb_orderby.Size = new System.Drawing.Size(221, 404);
            this.lisb_orderby.TabIndex = 16;
            this.lisb_orderby.SelectedIndexChanged += new System.EventHandler(this.lisb_orderby_SelectedIndexChanged);
            // 
            // btn_look
            // 
            this.btn_look.BackColor = System.Drawing.Color.Transparent;
            this.btn_look.Location = new System.Drawing.Point(658, 395);
            this.btn_look.Name = "btn_look";
            this.btn_look.Size = new System.Drawing.Size(75, 37);
            this.btn_look.TabIndex = 25;
            this.btn_look.Text = "在线收看";
            this.btn_look.UseVisualStyleBackColor = false;
            this.btn_look.Click += new System.EventHandler(this.btn_look_Click);
            // 
            // btn_search
            // 
            this.btn_search.Location = new System.Drawing.Point(348, 395);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(77, 37);
            this.btn_search.TabIndex = 24;
            this.btn_search.Text = "查询";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // rtb_xping
            // 
            this.rtb_xping.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rtb_xping.ForeColor = System.Drawing.Color.Black;
            this.rtb_xping.Location = new System.Drawing.Point(467, 211);
            this.rtb_xping.Name = "rtb_xping";
            this.rtb_xping.Size = new System.Drawing.Size(436, 150);
            this.rtb_xping.TabIndex = 23;
            this.rtb_xping.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(252, 211);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 16);
            this.label1.TabIndex = 22;
            this.label1.Text = "资源信息：";
            // 
            // rtb_messagebox
            // 
            this.rtb_messagebox.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rtb_messagebox.ForeColor = System.Drawing.Color.Red;
            this.rtb_messagebox.Location = new System.Drawing.Point(361, 72);
            this.rtb_messagebox.Name = "rtb_messagebox";
            this.rtb_messagebox.Size = new System.Drawing.Size(542, 107);
            this.rtb_messagebox.TabIndex = 21;
            this.rtb_messagebox.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(252, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 16);
            this.label2.TabIndex = 20;
            this.label2.Text = "资源下载：";
            // 
            // txt_name
            // 
            this.txt_name.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.txt_name.Location = new System.Drawing.Point(361, 25);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(225, 26);
            this.txt_name.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(252, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 16);
            this.label3.TabIndex = 19;
            this.label3.Text = "电影名称：";
            // 
            // pic_img
            // 
            this.pic_img.Location = new System.Drawing.Point(361, 211);
            this.pic_img.Name = "pic_img";
            this.pic_img.Size = new System.Drawing.Size(100, 150);
            this.pic_img.TabIndex = 17;
            this.pic_img.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1155, 456);
            this.Controls.Add(this.btn_look);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.rtb_xping);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rtb_messagebox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pic_img);
            this.Controls.Add(this.lisb_orderby);
            this.Controls.Add(this.com_orderby);
            this.Controls.Add(this.lisb_movie);
            this.Controls.Add(this.cmb_type);
            this.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "豆瓣电影排行榜";
            ((System.ComponentModel.ISupportInitialize)(this.pic_img)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cmb_type;
        private System.Windows.Forms.ListBox lisb_movie;
        private System.Windows.Forms.ComboBox com_orderby;
        private System.Windows.Forms.ListBox lisb_orderby;
        private System.Windows.Forms.Button btn_look;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.RichTextBox rtb_xping;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox rtb_messagebox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pic_img;
    }
}

