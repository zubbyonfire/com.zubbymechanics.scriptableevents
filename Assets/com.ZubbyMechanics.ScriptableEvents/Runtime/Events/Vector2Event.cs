using UnityEngine;
using System.Collections;

namespace Zubbyonfire.ScriptableObjectEvents
{
    [CreateAssetMenu(fileName = "New Vector2 Event", menuName = "Events/Vector2 Event")]
    [System.Serializable]
    public class Vector2Event : BaseGameEvent<Vector2> { }
}
