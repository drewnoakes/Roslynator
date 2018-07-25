﻿// Copyright (c) Josef Pihrt. All rights reserved. Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System;

#pragma warning disable CS1591, CA1051, CA1822

namespace Roslynator.Documentation.Test
{
    public class C : B
    {
        new public string Field;

        new public string Method() => "";

        new public string ToString() => "";

        new public int this[int index] => index;

        new public string Property { get; }

        new public event EventHandler Event;
    }
}
