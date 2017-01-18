using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Runtime.Serialization;
using FX110.AutoMap;
using System.Diagnostics;

namespace JsonPropertyTest
{
    class Program
    {
        protected static IAutoMapperService automapperservice = new FX110.AutoMap.AutoMapperServiceProvider();
        static void Main(string[] args)
        {
            List<APIModel.JsonChatMessage> ListsModel = new List<APIModel.JsonChatMessage>();
            for (int i = 0; i < 20; i++)
            {
                APIModel.JsonChatMessage msg1 = new APIModel.JsonChatMessage();
                msg1.ChatMsgContent = new APIModel.ChatMsgContent()
                {
                    CmType = APIModel.ChatMsgType.TXT,
                    LongMsgDateTime = "",
                    MsgContent = "消息记录123123123123",
                    MsgDateTime = DateTime.Now,
                    UniqueIdentification = Guid.NewGuid().ToString(),
                    AtUsers = new List<APIModel.Receiver>()

                };
                msg1.ChatMsgContent.AtUsers.Add(new APIModel.Receiver() { ReceiverID = "123123" });
                msg1.CType = APIModel.ChatType.PersonChat;
                msg1.Receiver = new APIModel.Receiver();
                msg1.Sender = new APIModel.Sender();

                ListsModel.Add(msg1);
            }


            automapperservice.RegisterMapper("JsonPropertyTest.AutoMap");

            Stopwatch watch = new Stopwatch();
            watch.Start();
            var cachemsg = automapperservice.Map<List<RedisModel.JsonChatMessage>>(ListsModel);
            watch.Stop();
            Console.WriteLine(watch.ElapsedMilliseconds);
            Console.ReadKey();

        }
    }
    public class PersonModel
    {
        [JsonProperty(PropertyName = "A", IsReference = false)]
        public string Name
        {
            get;
            set;
        }
        [JsonProperty("B")]
        public string Age { get; set; }
        [JsonProperty("D")]
        public PersonDetailsModel Model
        {
            get; set;
        }
    }

    public class PersonDetailsModel
    {
        [JsonProperty("A")]
        public string Sex { get; set; }
    }
}
