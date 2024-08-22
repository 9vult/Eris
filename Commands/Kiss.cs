using Discord;
using Discord.WebSocket;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eris.Commands
{
    internal class Kiss
    {
        public static async Task Execute(SocketSlashCommand interaction)
        {
            var imgUrl = await Api.GetAsync(Api.KISS);
            var guildUser = (SocketGuildUser)interaction.Data.Options.First().Value;

            if (imgUrl.StartsWith("Error"))
            {
                await interaction.FollowupAsync(imgUrl);
                return;
            }

            var embed = new EmbedBuilder()
                .WithImageUrl(imgUrl);

            await interaction.FollowupAsync(text: $"_Kisses <@{guildUser.Id}>_", embed: embed.Build());
        }
    }
}
