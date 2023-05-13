using DiscordRPC;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DiscordRichPresenceTest {
    class Program {
        public async static Task Main() {
            var client = new DiscordRpcClient("888182779664285716");
            client.Initialize();
            client.SetPresence(new RichPresence() {
                Buttons = new Button[2] {
                    new Button() {
                        Label = "youtube",
                        Url = "https://www.youtube.com/@VALORANTjp"
                    },
                    new Button() {
                        Label = "twitch",
                        Url = "https://www.twitch.tv/valorant_jpn"
                    },
                },
                Details = "2023 VCT Pacific - League Play - Day X",
                State = "#ZETA WIN",
                Timestamps = Timestamps.Now,
                Assets = new Assets() {
                    LargeImageKey = "valorant",
                    LargeImageText = "",
                    SmallImageKey = "yurisi"
                }
            });
            await Task.Delay(-1);
        }
    }
}