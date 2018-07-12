﻿// Copyright (c) Josef Pihrt. All rights reserved. Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System;

#pragma warning disable CS0618, CS1591, RCS1079 

namespace Roslynator.Documentation.Test
{
    [AttributeUsage(AttributeTargets.All, AllowMultiple = false)]
    public sealed class MyAttribute : Attribute
    {
    }
}