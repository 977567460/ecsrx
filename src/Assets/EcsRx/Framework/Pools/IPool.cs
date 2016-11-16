﻿using System.Collections.Generic;
using EcsRx.Blueprints;
using EcsRx.Entities;
using EcsRx.Pools.Identifiers;

namespace EcsRx.Pools
{
    public interface IPool
    {
        string Name { get; }

        IEnumerable<IEntity> Entities { get; }
        IIdentityGenerator IdentityGenerator { get; }

        IEntity CreateEntity(IBlueprint blueprint = null);
        void RemoveEntity(IEntity entity);
    }
}
