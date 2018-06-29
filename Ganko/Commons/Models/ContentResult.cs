using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ganko.Commons.Models
{
    class ContentResult
    {
        private string _id;
        private string content;
        private DateTime created_at;
        private DateTime publishedAt;
        private string rand_id;
        private string title;
        private DateTime updated_at;

        public string Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public string Content
        {
            get { return content; }
            set { content = value; }
        }

        public DateTime CreatedAt
        {
            get { return created_at; }
            set { created_at = value; }
        }

        public DateTime PublishedAt
        {
            get { return publishedAt; }
            set { publishedAt = value; }
        }

        public string Rand_id
        {
            get { return rand_id; }
            set { rand_id = value; }
        }

        public string Title
        {
            get { return title; }
            set { title = value; }
        }

        public DateTime UpdatedAt
        {
            get { return updated_at; }
            set { updated_at = value; }
        }
    }

    class ContentResultRoot
    {
        public bool Error { get; set; }
        public List<ContentResult> Results { get; set; }
    }
}
