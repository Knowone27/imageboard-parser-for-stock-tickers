using System;
using System.Collections.Generic;
using System.Net;
using Newtonsoft.Json;

namespace fren
{

    public class Rootobject
    {
        public Post[] posts 
        { get; set; }
    }

    public class Post
    {
       public string com 
       { get; set; }
       
    }



    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> dictionary = new Dictionary<string, int>();
            string[] subString;
            
            WebClient client = new WebClient();
            string json = client.DownloadString("https://a.4cdn.org/biz/thread/37631449.json");
            dynamic jsonobj = JsonConvert.DeserializeObject<dynamic>(json);

            string jsonText = jsonobj.ToString();

            char[] separators = new char[] { ' ', '.', '?', '!', ',', '"','>','$','<', '&', };

            subString = jsonText.Split(separators, StringSplitOptions.RemoveEmptyEntries);




            foreach (string word in subString)
            {
                bool wordUpper = false;

                for (int i = 0; i < word.Length; i++)
                {
                    if (char.IsUpper(word[i]) && char.IsLetter(word[i]) && word.Length <= 5 && word.Length >= 2)
                    {
                        wordUpper = true;

                    }
                    
                    else
                    {
                        wordUpper = false;
                    }

                }


                if (wordUpper == true)
                {
                    if (dictionary.ContainsKey(word))
                    {
                        dictionary[word] += 1;
                    }
                    else
                    {
                        dictionary.Add(word, 1);
                    }
                }





            }


            Console.WriteLine("Ticker:      Amount mentioned: ");

            foreach (KeyValuePair<string, int> kvp in dictionary)
            {
                Console.WriteLine("{0}                              {1}", kvp.Key, kvp.Value);
            }




            
        }
    }
}
