using UnityEngine;
using System.Collections;

namespace Zubbyonfire.ScriptableObjectEvents
{
    [CreateAssetMenu(fileName = "New Float Event", menuName = "Events/Float Event")]
    [System.Serializable]
    public class FloatEvent : BaseGameEvent<float> { }
}
