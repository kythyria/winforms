﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

internal static partial class Interop
{
    internal static partial class Gdi32
    {
        [DllImport(Libraries.Gdi32, ExactSpelling = true)]
        public static extern MM GetMapMode(IntPtr hdc);

        public static MM GetMapMode(IHandle hdc)
        {
            MM result = GetMapMode(hdc.Handle);
            GC.KeepAlive(hdc);
            return result;
        }
    }
}
