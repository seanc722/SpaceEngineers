﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace VRage
{
    public struct MyTuple
    {
        public static MyTuple<T1> Create<T1>(T1 arg1)
        {
            return new MyTuple<T1>(arg1);
        }
        public static MyTuple<T1, T2> Create<T1, T2>(T1 arg1, T2 arg2)
        {
            return new MyTuple<T1, T2>(arg1, arg2);
        }
        public static MyTuple<T1, T2, T3> Create<T1, T2, T3>(T1 arg1, T2 arg2, T3 arg3)
        {
            return new MyTuple<T1, T2, T3>(arg1, arg2, arg3);
        }
        public static MyTuple<T1, T2, T3, T4> Create<T1, T2, T3, T4>(T1 arg1, T2 arg2, T3 arg3, T4 arg4)
        {
            return new MyTuple<T1, T2, T3, T4>(arg1, arg2, arg3, arg4);
        }
        public static MyTuple<T1, T2, T3, T4, T5> Create<T1, T2, T3, T4, T5>(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5)
        {
            return new MyTuple<T1, T2, T3, T4, T5>(arg1, arg2, arg3, arg4, arg5);
        }
        public static MyTuple<T1, T2, T3, T4, T5, T6> Create<T1, T2, T3, T4, T5, T6>(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6)
        {
            return new MyTuple<T1, T2, T3, T4, T5, T6>(arg1, arg2, arg3, arg4, arg5, arg6);
        }
    }

    [StructLayout(LayoutKind.Sequential, Pack = 4)]
    public struct MyTuple<T1>
    {
        public T1 Item1;

        public MyTuple(T1 item1)
        {
            Item1 = item1;
        }
    }

    [StructLayout(LayoutKind.Sequential, Pack = 4)]
    public struct MyTuple<T1, T2>
    {
        public T1 Item1;
        public T2 Item2;

        public MyTuple(T1 item1, T2 item2)
        {
            Item1 = item1;
            Item2 = item2;
        }
    }

    [StructLayout(LayoutKind.Sequential, Pack = 4)]
    public struct MyTuple<T1, T2, T3>
    {
        public T1 Item1;
        public T2 Item2;
        public T3 Item3;

        public MyTuple(T1 item1, T2 item2, T3 item3)
        {
            Item1 = item1;
            Item2 = item2;
            Item3 = item3;
        }
    }

    [StructLayout(LayoutKind.Sequential, Pack = 4)]
    public struct MyTuple<T1, T2, T3, T4>
    {
        public T1 Item1;
        public T2 Item2;
        public T3 Item3;
        public T4 Item4;

        public MyTuple(T1 item1, T2 item2, T3 item3, T4 item4)
        {
            Item1 = item1;
            Item2 = item2;
            Item3 = item3;
            Item4 = item4;
        }
    }

    [StructLayout(LayoutKind.Sequential, Pack = 4)]
    public struct MyTuple<T1, T2, T3, T4, T5>
    {
        public T1 Item1;
        public T2 Item2;
        public T3 Item3;
        public T4 Item4;
        public T5 Item5;

        public MyTuple(T1 item1, T2 item2, T3 item3, T4 item4, T5 item5)
        {
            Item1 = item1;
            Item2 = item2;
            Item3 = item3;
            Item4 = item4;
            Item5 = item5;
        }
    }

    [StructLayout(LayoutKind.Sequential, Pack = 4)]
    public struct MyTuple<T1, T2, T3, T4, T5, T6>
    {
        public T1 Item1;
        public T2 Item2;
        public T3 Item3;
        public T4 Item4;
        public T5 Item5;
        public T6 Item6;

        public MyTuple(T1 item1, T2 item2, T3 item3, T4 item4, T5 item5, T6 item6)
        {
            Item1 = item1;
            Item2 = item2;
            Item3 = item3;
            Item4 = item4;
            Item5 = item5;
            Item6 = item6;
        }
    }
}
