﻿using SharpDX;
using SharpDX.Direct3D;
using SharpDX.Direct3D11;
using SharpDX.DXGI;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using VRage.Generics;

using VRageMath;
using VRageRender.Resources;
using VRageRender.Vertex;
using Buffer = SharpDX.Direct3D11.Buffer;
using Matrix = VRageMath.Matrix;
using Vector3 = VRageMath.Vector3;
using BoundingBox = VRageMath.BoundingBox;
using BoundingFrustum = VRageMath.BoundingFrustum;
using VRage.Collections;
using System.Collections.Specialized;
using System.Threading;


namespace VRageRender
{

    static class MyActorFactory
    {
        static MyObjectsPool<MyActor> m_pool = new MyObjectsPool<MyActor>(50);

        internal static MyActor Create()
        {
            MyActor item;
            m_pool.AllocateOrCreate(out item);
            item.Construct();
            return item;
        }

        internal static MyActor CreateSceneObject()
        {
            var actor = Create();
            actor.AddComponent(MyComponentFactory<MyRenderableComponent>.Create());
            return actor;
        }

        internal static MyActor CreateCharacter()
        {
            var actor = Create();
            actor.AddComponent(MyComponentFactory<MyRenderableComponent>.Create());
            actor.AddComponent(MyComponentFactory<MySkinningComponent>.Create());
            return actor;
        }

        //internal static MyActor CreateCullObject()
        //{
        //    var actor = Create();
        //    actor.AddComponent(MyComponentFactory<MyHierarchyComponent>.Create());
        //    return actor;
        //}

        internal static MyActor CreateGroup()
        {
            var actor = Create();
            actor.AddComponent(MyComponentFactory<MyGroupRootComponent>.Create());
            return actor;
        }

        internal static void RemoveAll()
        {
            foreach(var actor in m_pool.Active)
            {
                actor.Destruct();
            }
            m_pool.DeallocateAll();
        }

        internal static void Destroy(MyActor item)
        {
            item.Destruct();
            m_pool.Deallocate(item);
        }

        internal static HashSetReader<MyActor> GetAll()
        {
            return m_pool.Active;
        }
    }
}