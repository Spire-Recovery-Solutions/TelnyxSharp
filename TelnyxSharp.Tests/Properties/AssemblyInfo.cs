using TUnit.Core;
using TUnit.Core.Interfaces;
using TelnyxSharp.Tests;

// Run integration tests sequentially to avoid race conditions and resource
// conflicts against the live Telnyx API when TELNYX_API_KEY is set.
[assembly: ParallelLimiter<SingleThreadedParallelLimit>]

namespace TelnyxSharp.Tests
{
    public sealed class SingleThreadedParallelLimit : TUnit.Core.Interfaces.IParallelLimit
    {
        public int Limit => 1;
    }
}
