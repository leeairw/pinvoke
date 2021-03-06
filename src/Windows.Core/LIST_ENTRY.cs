﻿// Copyright (c) All contributors. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace PInvoke
{
    using System.Runtime.InteropServices;

    /// <summary>
    /// Describes a link in a doubly-linked list.
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    [OfferIntPtrPropertyAccessors]
    public unsafe partial struct LIST_ENTRY
    {
        public LIST_ENTRY* Flink;
        public LIST_ENTRY* Blink;
    }
}
