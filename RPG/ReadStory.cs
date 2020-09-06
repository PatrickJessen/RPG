using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace RPG
{
    class ReadStory
    {
        const string path = @"StoryFile.json";
        string json = File.ReadAllText(path);
        public void CreateJson()
        {
            MyStory story = new MyStory();
            StreamWriter file = File.CreateText(path);
            JsonSerializer serializer = new JsonSerializer();
            serializer.Serialize(file, story);
        }

        public string ReadMyStory(string story)
        {
            JObject test = JObject.Parse(json);
            return test[story].ToString();
        }
    }
}
