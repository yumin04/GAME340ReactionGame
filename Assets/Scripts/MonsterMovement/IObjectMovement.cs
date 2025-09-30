using UnityEngine;

namespace MonsterMovement
{
    public abstract class IObjectMovement : ScriptableObject
    {
        public abstract void Move(GameObject monster);
    }
}
