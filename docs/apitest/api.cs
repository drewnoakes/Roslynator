﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Immutable;

namespace System
{
    [CLSCompliant(true)]
    [Obsolete]
    public class ClassName
    {
        public ClassName();
    }
}

namespace Roslynator.Documentation.Test
{
    public class B
    {
        public const string FooConst = "abc";

        public string Field;

        public B();

        public event EventHandler Event;

        public int this[int index] { get; }

        public string Property { get; }

        public string Method();
    }

    public class C : B
    {
        public string Field;

        public C();

        public event EventHandler Event;

        public int this[int index] { get; }

        public string Property { get; }

        public string Method();
        public string ToString();
    }

    [Obsolete("Foo is obsolete.")]
    public class Foo : Bla
    {
        public const string FooConst = "abc";

        public readonly string Field;

        public Foo(string s);
        public Foo(string s, string methods);

        public Foo this[int index, int index2] { get; set; }
        public Foo this[int index] { get; set; }

        public void Bar();
        public void Bar<T, T2>(string value, string value2);
        public void Bar2();
        public void WriteString(char* pSrcStart, char* pSrcEnd);
    }

    [AttributeUsage(AttributeTargets.All, AllowMultiple = false, Inherited = false)]
    public sealed class FooAttribute : Attribute
    {
        [Foo(null, "\\n", true, false, 0, '\'', 0, 0, 0, 0, 0, 0, 0, 0, 0, typeof(object), Flags.None, Flags.A, Flags.A, Flags.AB | Flags.C, Flags.AB, (Flags)100)]
        public FooAttribute(object object1, string s1, bool bool1, bool bool2, byte byte1, char ch1, double double1, float float1, int int1, long long1, sbyte sbyte1, short short1, uint uint1, ulong ulong1, ushort ushort1, Type type, Flags f1, Flags f2, Flags f3, Flags f4, Flags f5, Flags f6);
    }

    public class FooCollection : ICollection, ICollection<Foo>, IEnumerable<Foo>
    {
        public FooCollection();

        public int Count { get; }
        public bool IsReadOnly { get; }
        public bool IsSynchronized { get; }
        public object SyncRoot { get; }

        public void Add(Foo item);
        public void Clear();
        public bool Contains(Foo item);
        public void CopyTo(Array array, int index);
        public void CopyTo(Foo[] array, int arrayIndex);
        public IEnumerator GetEnumerator();
        public bool Remove(Foo item);
    }

    [Obsolete]
    public class FooDic<TKey, TValue> : IEnumerable<KeyValuePair<TKey, TValue>>, IEnumerable<TValue>, IReadOnlyCollection<KeyValuePair<TKey, TValue>>, IReadOnlyList<KeyValuePair<TKey, TValue>> where TKey : Foo where TValue : Foo
    {
        public FooDic();
    }

    public class FooEvent : IFoo
    {
        public FooEvent();
    }

    public static class FooExtensions
    {
    }

    public struct FooStruct
    {
        public void Bar();
    }

    public interface IFoo
    {
        event EventHandler Changed;
    }

    public interface IImmutableFoo<T> : IEquatable<IImmutableFoo<T>>, ICollection, IList, IStructuralComparable, IStructuralEquatable, ICollection<T>, IEnumerable<T>, IList<T>, IReadOnlyCollection<T>, IReadOnlyList<T>, IImmutableList<T>
    {
        T this[int index] { get; set; }
    }

    [Flags]
    public enum Flags
    {
        None = 0,
        A = 1,
        B = 2,
        AB = A | B,
        C = 4,
        D = 8,
    }

    public delegate Foo FooDelegate(object p);
}

[CLSCompliant(true)]
public class Bla
{
    public Bla();

    public void M();
}
