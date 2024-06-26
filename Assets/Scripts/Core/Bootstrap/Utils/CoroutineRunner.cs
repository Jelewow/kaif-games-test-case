using System;
using UnityEngine;

namespace Bootstrap.Utils
{
    public class CoroutineRunner : MonoBehaviour, ICoroutineRunner
    {
        private void Awake()
        {
            DontDestroyOnLoad(this);
        }
    }
}