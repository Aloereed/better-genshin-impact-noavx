﻿using BetterGenshinImpact.GameTask.Model;
using System.Threading;

namespace BetterGenshinImpact.GameTask.AutoTrackPath;

public class AutoTrackPathParam : BaseTaskParam
{
    public AutoTrackPathParam(CancellationTokenSource cts) : base(cts)
    {
    }
}
