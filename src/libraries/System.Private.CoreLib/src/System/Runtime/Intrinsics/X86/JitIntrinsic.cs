// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Runtime.CompilerServices;

namespace System.Runtime.Intrinsics.X86
{
    /// <summary>
    /// This class provides access to ??? hardware instructions via intrinsics
    /// </summary>
    [Intrinsic]
    [CLSCompliant(false)]
    public abstract class JitIntrinsic
    {
        internal JitIntrinsic() { }

        public static bool IsSupported { get => X86Base.IsSupported; }

        /// <summary>
        /// void* _ReturnAddress()
        /// </summary>
        public static unsafe void* ReturnAddress() => ReturnAddress();

        /// <summary>
        /// void* _AddressOfReturnAddress()
        /// </summary>
        public static unsafe void** AddressOfReturnAddress() => AddressOfReturnAddress();

    }
}
