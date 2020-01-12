using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Zubbyonfire.ScriptableObjectEvents
{
    public interface IGameEventListener<T>
    {
        void OnEventRaised(T item);
    }
}