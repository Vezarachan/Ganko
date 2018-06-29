using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ganko.Commons.Models
{
    public class ResultModel
    {
        public string _id { get; set; }

        public DateTime createdAt { get; set; }

        public string desc { get; set; }

        public List<string> images { get; set; }

        public DateTime publishedAt { get; set; }

        public string source { get; set; }

        public string type { get; set; }

        public string url { get; set; }

        public string used { get; set; }

        public string who { get; set; }

    }

    class iOS : ResultModel { }

    class Android : ResultModel { }

    class 前端 : ResultModel { }

    class 休闲视频 : ResultModel { }

    class 拓展资源 : ResultModel { }

    class App : ResultModel { }

    class 福利 : ResultModel { }

    class ResultModelRoot<T> where T : ResultModel
    {
        public bool Error { get; set; }
        public List<T> Results { get; set; }
    }

}
