﻿using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;

namespace SignalRApi.Models
{
    public class Recognizer: Hub
    {
        public async IAsyncEnumerable<int> Counter(int count, int delay, [EnumeratorCancellation] CancellationToken cancellationToken)
        {
            for (int i = 0; i < count; i++)
            {
                cancellationToken.ThrowIfCancellationRequested();

                yield return i;

                await Task.Delay(delay, cancellationToken);
            }
        }
    }
}
