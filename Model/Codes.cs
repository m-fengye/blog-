using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Codes
    {
        int id;
        string title;
        string code;
        string download;
        DateTime time;
        string author;
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
        /// 代码
        /// </summary>
        public string Code
        {
            get { return code; }
            set { code = value; }
        }
        /// <summary>
        /// 下载链接
        /// </summary>
        public string Download
        {
            get { return download; }
            set { download = value; }
        }
        /// <summary>
        /// 发布时间
        /// </summary>
        public DateTime Time
        {
            get { return time; }
            set { time = value; }
        }
        /// <summary>
        /// 作者
        /// </summary>
        public string Author
        {
            get { return author; }
            set { author = value; }
        }

    }
}
