using UnityEngine;

namespace MonsterMovement
{
    public abstract class IObjectMovement : ScriptableObject
    {
        public abstract float ReturnCalculatedPosition(float ratio);
    }
}
