using System.Collections.Generic;
using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Runtime.Serialization;
using Newtonsoft.Json.Serialization;

namespace Bookworm.Models
{
    public class Book
    {
        [JsonProperty("bookId")]
        public int BookId { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("author")]
        public string Author { get; set; }

        [JsonProperty("ageRange")]
        public string AgeRange { get; set; }

        [JsonProperty("summary")]
        public string Summary { get; set; }

        [JsonProperty("genre")]
        public string Genre { get; set; }

        [JsonProperty("tags")]
        public string Tags { get; set; }

        public static List<Book> GetBooks()
        {
          var apiCallTask = ApiHelper.GetAll();
          var result = apiCallTask.Result;
          
          JObject jsonResponse = JsonConvert.DeserializeObject<JObject>(result);

          // JArray jsonResponse = JsonConvert.DeserializeObject<JArray>(result);
          
          //List<Book> bookList = JsonConvert.DeserializeObject<List<Book>>(jsonResponse["result"].ToString());


List<Book> bookList = JsonConvert.DeserializeObject<List<Book>>(jsonResponse["results"].ToString());

          return bookList;
    
        }
    }
}