using UnityEngine;
using System.Collections;

namespace Zubbyonfire.ScriptableObjectEvents
{
    [CreateAssetMenu(fileName = "New GameObject Event", menuName = "Events/GameObject Event")]
    [System.Serializable]
    public class GameObjectEvent : BaseGameEvent<GameObject> { }
}
