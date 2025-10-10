using UnityEngine;

[CreateAssetMenu(menuName = "MonsterMovement/Linear")]
public class LinearMovementSO : MonsterMovement.IObjectMovement
{

    public override float ReturnCalculatedPosition(float ratio)
    {
        return NumberFunction(ratio);
    }

    private float NumberFunction(float x)
    {
        return x;
    }
}