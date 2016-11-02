﻿using EcsRx.Unity;
using EcsRx.Unity.Components;

namespace Assets.EcsRx.Examples.AutoRegisterSystems
{
    public class Application : EcsRxApplication
    {
        protected override void GameStarting()
        {
            RegisterAllBoundSystems();
        }

        protected override void GameStarted()
        {
            var defaultPool = PoolManager.GetPool();
            var entity = defaultPool.CreateEntity();
            entity.AddComponent(new ViewComponent());
        }
    }
}