﻿using System.Threading.Tasks;

namespace Bot.BotLists.Interfaces.Services
{
    public interface IBotListUpdater
    {


        /// <summary>
        /// Updates the stats for all the bot lists.
        /// </summary>
        /// <param name="shardCount">The total amount of shards the client has.</param>
        /// <param name="guildCount">The amount of server the client is in.</param>
        /// <param name="shardId">The shard id.</param>
        /// <returns>An awaitable <see cref="Task"/>.</returns>
        Task UpdateStatusAsync(int shardCount, int guildCount, int shardId = 0);

    }
}