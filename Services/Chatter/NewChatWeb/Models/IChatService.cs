﻿// ------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All rights reserved.
//  Licensed under the MIT License (MIT). See License.txt in the repo root for license information.
// ------------------------------------------------------------

namespace NewChatWeb.Domain
{
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Microsoft.ServiceFabric.Services.Remoting;

    public interface IChatService : IService
    {
        Task AddMessageAsync(Message message);
        Task<IEnumerable<KeyValuePair<DateTime, Message>>> GetMessagesAsync();
        Task ClearMessagesAsync();
        Task<string> GetCurrentQuestionAsync();
        Task<IEnumerable<KeyValuePair<string, int>>> GetScoresAsync();
    }
}