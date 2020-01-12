using UnityEngine;
using System.Collections;

namespace Zubbyonfire.ScriptableObjectEvents
{
    [CreateAssetMenu(fileName = "New String Event", menuName = "Events/String Event")]
    [System.Serializable]
    public class StringEvent : BaseGameEvent<string> { }
}
