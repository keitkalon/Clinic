﻿using PlatformService.Dtos;

namespace PlatformService.SyncDataServices.Http
{
    public interface ICommandDataClient
    {
        public Task SendProfileToCommand(ProfileReadDtos profile);
    }
}
