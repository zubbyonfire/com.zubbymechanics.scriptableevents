using UnityEngine;

namespace Zubbyonfire.ScriptableObjectEvents
{
    [CreateAssetMenu(fileName ="New Void Event", menuName ="Events/Void Event")]
    [System.Serializable]
    public class VoidEvent : BaseGameEvent<Void>
    {
        public void Raise() => Raise(new Void());
    }
}