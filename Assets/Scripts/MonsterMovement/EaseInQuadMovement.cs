
using UnityEngine;

[CreateAssetMenu(menuName = "MonsterMovement/EaseInQuadMovement")]
public class EaseInQuadMovementSO : MonsterMovement.IObjectMovement
{
    public override void Move(GameObject monster)
    {
        Debug.Log("Ease In Quad Move with ScriptableObject!");
    }
}