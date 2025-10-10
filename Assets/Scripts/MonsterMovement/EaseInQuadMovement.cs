
using UnityEngine;

[CreateAssetMenu(menuName = "MonsterMovement/EaseInQuadMovement")]
public class EaseInQuadMovementSO : MonsterMovement.IObjectMovement
{

    public override float ReturnCalculatedPosition(float ratio)
    {
        return NumberFunction(ratio);
    }

    private float NumberFunction(float x)
    {
        return x * x;
    }
}