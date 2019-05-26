using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Blogs
    {
        int id;
        string title;
        string blogContent;
        DateTime blogTime;
        string author;
        string layout;
        /// <summary>
        /// 主键ID
        /// </summary>
        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        /// <summary>
        /// 标题
        /// </summary>
        public string Title
        {
            get { return title; }
            set { title = value; }
        }
        /// <summary>
        /// 博客内容
        /// </summary>
        public string BlogContent
        {
            get { return blogContent; }
            set { blogContent = value; }
        }
        /// <summary>
        /// 发布时间
        /// </summary>
        public DateTime BlogTime
        {
            get { return blogTime; }
            set { blogTime = value; }
        }
        /// <summary>
        /// 作者
        /// </summary>
        public string Author
        {
            get { return author; }
            set { author = value; }
        }
        /// <summary>
        /// 主页配图
        /// </summary>
        public string Layout
        {
            get { return layout; }
            set { layout = value; }
        }
    }
}
