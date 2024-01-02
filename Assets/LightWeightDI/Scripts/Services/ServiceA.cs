﻿using UnityEngine;

namespace DependencyInjection
{
    public class ServiceA : IServiceA
    {
        public void Initialize(string message = null)
        {
            Debug.Log($"ServiceA.Initialize({message})");
        }
    }
}