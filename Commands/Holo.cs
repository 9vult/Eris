using Discord;
using Discord.WebSocket;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eris.Commands
{
    internal class Holo
    {
        public static async Task Execute(SocketSlashCommand interaction)
        {
            var imgUrl = await Api.GetAsync(Api.HOLO);

            if (imgUrl.StartsWith("Error"))
            {
                await interaction.FollowupAsync(imgUrl);
                return;
            }

            var embed = new EmbedBuilder()
                .WithImageUrl(imgUrl);

            await interaction.FollowupAsync(embed: embed.Build());
        }
    }
}
