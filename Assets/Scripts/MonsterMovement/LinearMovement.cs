using UnityEngine;

[CreateAssetMenu(menuName = "MonsterMovement/Linear")]
public class LinearMovementSO : MonsterMovement.IObjectMovement
{
    public override void Move(GameObject monster)
    {
        Debug.Log("Linear Move with ScriptableObject!");
    }
}