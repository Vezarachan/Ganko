using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Ganko.Commons.Models;
using Newtonsoft.Json;

namespace Ganko.ApiProcessor
{

    /// <summary>
    /// API处理类，用于处理Gank.io提供的api
    /// 不可实例化
    /// </summary>
    class APIProcessor : ICloneable
    {
        private static readonly HttpClient httpClient = new HttpClient();
        private string url = "http://gank.io/api/data/";

        private APIProcessor() { }

        //重写Clone方法，实现ICloneable接口
        public object Clone()
        {
            return new APIProcessor().MemberwiseClone();
        }

        //获取APIProcessor实例
        public static APIProcessor GetInstance()
        {
            APIProcessor apiProcessor = new APIProcessor();
            try
            {
                return (APIProcessor)apiProcessor.Clone();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        //利用HttpClient获取JSON
        public async Task<string> GetJsonAsync(string url)
        {
            var response = await httpClient.GetAsync(url);
            response.EnsureSuccessStatusCode();
            var json = response.Content.ReadAsStringAsync();
            return await json;
        }

        //对获取的JSON进行反序列化
        public T Deserialize<T>(string json)
        {
            return JsonConvert.DeserializeObject<T>(json);
        }

        //获取反馈的JSON，并转化为对象
        public async Task<List<T>> GetResultContent<T>(int pageSize, int pageNum) where T : ResultModel
        {
            var url = $"http://gank.io/api/data/{typeof(T).Name}/{pageSize}/{pageNum}";
            var json = await GetJsonAsync(url);
            var response = JsonConvert.DeserializeObject<ResultModelRoot<T>>(json);
            return response.Error ? null : response.Results;
        }

        //返回按日期返回的Web API地址
        private static string contentUrl(int y, int m, int d) => $"http://gank.io/api/history/content/day/{y}/{m}/{d}";

        //根据日期获取内容
        public async Task<ContentResultRoot> GetContentbyDate<T>(DateTime dateTime)
        {
            var url = contentUrl(dateTime.Year, dateTime.Month, dateTime.Day);
            var json = await GetJsonAsync(url);
            var response = JsonConvert.DeserializeObject<ContentResultRoot>(json);
            return response.Error ? null : response;
        }
    }
}
