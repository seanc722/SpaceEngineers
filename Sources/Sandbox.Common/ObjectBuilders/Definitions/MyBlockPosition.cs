﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ProtoBuf;
using VRageMath;

namespace Sandbox.Common.ObjectBuilders.Definitions
{
    [ProtoContract]
    public class MyBlockPosition
    {
        [ProtoMember(1)]
        public string Name;

        [ProtoMember(2)]
        public Vector2I Position;
    }
}
