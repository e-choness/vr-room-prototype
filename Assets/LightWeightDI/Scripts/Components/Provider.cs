﻿using UnityEngine;

namespace DependencyInjection
{
    public class Provider : MonoBehaviour, IDependencyProvider
    {
        [Provide]
        public IServiceA ProvideServiceA()
        {
            return new ServiceA();
        }

        [Provide]
        public IServiceB ProvideServiceB()
        {
            return new ServiceB();
        }

        [Provide]
        public IServiceC ProvideServiceC()
        {
            return new ServiceC();
        }

        [Provide]
        public IFactoryA ProvideFactoryA()
        {
            return new FactoryA();
        }
    }
}