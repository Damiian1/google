﻿using Discord;
using RoleButtonsBot.DTO;
namespace TestEasyBot.Modules
            {
                await Context.Channel.SendMessageAsync("Link cant create link cause it already exist!");
            }
            else
            {
                var link = new ButtonLinks();
                link.GuildID = Context.Guild.Id;
                link.MessageID = MessageID;
                link.RoleID = RoleID;
                link.Emoji = Icon;
                link.CreatedByID = Context.User.Id;
                link.Created = DateTime.Now;
                CommandHandler.buttonlinks.Add(link);
                await Context.Channel.SendMessageAsync("Link have been saved!");
                File.WriteAllText("ButtonLinks.json", JsonConvert.SerializeObject(CommandHandler.buttonlinks));
            }
        private static string GetHeapSize() => Math.Round(GC.GetTotalMemory(true) / (1024.0 * 1024.0), 2).ToString();
    }
}