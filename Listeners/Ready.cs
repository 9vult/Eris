using Discord;
using Discord.Net;
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
        public static async Task Ready()
        {
            var neko = new SlashCommandBuilder()
                .WithName("neko")
                .WithDescription("Summon a neko!");

            var kitsune = new SlashCommandBuilder()
                .WithName("kitsune")
                .WithDescription("Summon a kitsune!");

            var ookami = new SlashCommandBuilder()
                .WithName("ookami")
                .WithDescription("Summon an ookami!");

            var holo = new SlashCommandBuilder()
                .WithName("holo")
                .WithDescription("Summon Holo!");

            var senko = new SlashCommandBuilder()
                .WithName("senko")
                .WithDescription("Summon Senko!");

            var pat = new SlashCommandBuilder()
                .WithName("pat")
                .WithDescription("Pat someone")
                .AddOption("user", ApplicationCommandOptionType.User, "User to pat", isRequired: true);

            var hug = new SlashCommandBuilder()
                .WithName("hug")
                .WithDescription("Hug someone")
                .AddOption("user", ApplicationCommandOptionType.User, "User to hug", isRequired: true);

            var poke = new SlashCommandBuilder()
                .WithName("poke")
                .WithDescription("Poke someone")
                .AddOption("user", ApplicationCommandOptionType.User, "User to poke", isRequired: true);

            var slap = new SlashCommandBuilder()
                .WithName("slap")
                .WithDescription("Slap someone")
                .AddOption("user", ApplicationCommandOptionType.User, "User to slap", isRequired: true);

            var kiss = new SlashCommandBuilder()
                .WithName("kiss")
                .WithDescription("Kiss someone")
                .AddOption("user", ApplicationCommandOptionType.User, "User to kiss", isRequired: true);

            try
            {
                await Eris.Client.CreateGlobalApplicationCommandAsync(neko.Build());
                await Eris.Client.CreateGlobalApplicationCommandAsync(kitsune.Build());
                await Eris.Client.CreateGlobalApplicationCommandAsync(ookami.Build());
                await Eris.Client.CreateGlobalApplicationCommandAsync(holo.Build());
                await Eris.Client.CreateGlobalApplicationCommandAsync(senko.Build());
                await Eris.Client.CreateGlobalApplicationCommandAsync(pat.Build());
                await Eris.Client.CreateGlobalApplicationCommandAsync(hug.Build());
                await Eris.Client.CreateGlobalApplicationCommandAsync(poke.Build());
                await Eris.Client.CreateGlobalApplicationCommandAsync(slap.Build());
                await Eris.Client.CreateGlobalApplicationCommandAsync(kiss.Build());
            }
            catch (HttpException e)
            {
                var json = JsonConvert.SerializeObject(e.Errors, Formatting.Indented);
                Console.WriteLine(json);
            }
        }
    }
}
