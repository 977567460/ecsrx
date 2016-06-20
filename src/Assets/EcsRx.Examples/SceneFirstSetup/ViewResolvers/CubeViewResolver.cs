﻿using Assets.EcsRx.Examples.SceneFirstSetup.Components;
using EcsRx.Entities;
using EcsRx.Extensions;
using EcsRx.Groups;
using EcsRx.Pools;
using EcsRx.Unity.Systems;
using UnityEngine;

namespace Assets.EcsRx.Examples.SceneFirstSetup.ViewResolvers
{
    public class CubeViewResolver : ViewResolverSystem
    {
        private readonly Transform ParentTrasform = GameObject.Find("Entities").transform;

        public override IGroup TargetGroup
        {
            get { return base.TargetGroup.WithComponent<CubeComponent>(); }
        }

        public CubeViewResolver(IPoolManager poolManager) : base(poolManager) {}

        public override GameObject ResolveView(IEntity entity)
        {
            var view = GameObject.CreatePrimitive(PrimitiveType.Cube);
            view.transform.position = new Vector3(-2, 0, 0);
            view.transform.parent = ParentTrasform;
            return view;
        }
    }
}