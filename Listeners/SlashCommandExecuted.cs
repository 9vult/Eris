using Discord;
using Discord.Net;
using Discord.WebSocket;
using Eris.Commands;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eris.Listeners
{
    internal partial class Listener
    {
        public static async Task SlashCommandExecuted(SocketSlashCommand interaction)
        {
            await interaction.DeferAsync();

            switch (interaction.CommandName)
            {
                case "neko":
                    await Neko.Execute(interaction);
                    break;
                case "kitsune":
                    await Kitsune.Execute(interaction);
                    break;
                case "ookami":
                    await Ookami.Execute(interaction);
                    break;
                case "holo":
                    await Holo.Execute(interaction);
                    break;
                case "senko":
                    await Senko.Execute(interaction);
                    break;
                case "pat":
                    await Pat.Execute(interaction);
                    break;
                case "hug":
                    await Hug.Execute(interaction);
                    break;
                case "poke":
                    await Poke.Execute(interaction);
                    break;
                case "slap":
                    await Slap.Execute(interaction);
                    break;
                case "kiss":
                    await Kiss.Execute(interaction);
                    break;
            }
        }
    }
}
