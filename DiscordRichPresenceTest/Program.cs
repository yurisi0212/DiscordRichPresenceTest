using DiscordRPC;
using System.Threading.Tasks;

namespace DiscordRichPresenceTest {
   class Program {
      public async static Task Main() {
         var client = new DiscordRpcClient("888182779664285716");
         client.Initialize();
         client.SetPresence(new RichPresence() {
            Details = "VCT Stage 3 - MASTERS BERLIN Day 7",
            State = "Tenz最強！",
            Timestamps = Timestamps.Now,
            Assets = new Assets() {
               LargeImageKey = "valorant",
               LargeImageText = "最高っす",
               SmallImageKey = "yurisi"
            }
         });
         await Task.Delay(-1);
      }
   }
}