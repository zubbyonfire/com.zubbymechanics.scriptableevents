﻿using UnityEngine;
using System.Collections;

namespace Zubbyonfire.ScriptableObjectEvents
{
    [CreateAssetMenu(fileName ="New Int Event", menuName ="Events/Int Event")]
    [System.Serializable]
    public class IntEvent : BaseGameEvent<int> { }
}
