using System.Collections.Generic;
using UnityEngine;

public class MovementAssigner : MonoBehaviour
{
    [SerializeField] private List<MonsterMovement.IObjectMovement> movementSO;
    [SerializeField] private GameObject monster;

    void Start()
    {
        AssignMovementToMonster();
    }

    private void AssignMovementToMonster()
    {
        if (movementSO == null || movementSO.Count == 0) return;

        int index = Random.Range(0, movementSO.Count);
        MonsterMovement.IObjectMovement currentMovement = movementSO[index];
        
        currentMovement.Move(monster);
        Debug.Log("Assigned " + currentMovement.name + " to " + monster.name);
    }
}
