using System;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using Object = UnityEngine.Object;
using Random = UnityEngine.Random;

public class MovementAssigner : MonoBehaviour
{
    [SerializeField] private List<MonsterMovement.IObjectMovement> movementSO;
    [SerializeField] private GameObject monster;
    [SerializeField] private GameObject target;
    private GameObject monsterInRealGame;
    private GameObject targetInRealGame;

    private Action whenMonsterInitialized;
    
    

    
    private static MovementAssigner instance;

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        
    }

    void Start()
    {

    }
    public static MovementAssigner GetInstance()
    {
        return instance;
    }
    public void CreateMonster()
    {
        InstantiateMonster();
        AssignMovementToMonster();
    }

    private void InstantiateTarget(Vector3 position)
    {

        targetInRealGame = Instantiate(target, position, Quaternion.identity);
    }
    
    
    private void InstantiateMonster()
    {
        monsterInRealGame = Instantiate(monster);
    }

    private void AssignMovementToMonster()
    {
        if (movementSO == null || movementSO.Count == 0) return;

        int index = Random.Range(0, movementSO.Count);
        MonsterMovement.IObjectMovement currentMovement = movementSO[index];


        Monster monsterScript = monsterInRealGame.GetComponent<Monster>();
        
        float randomDuration = Random.Range(1f, 5f);

        monsterScript.SetMovement(currentMovement, randomDuration);
        
        InstantiateTarget(monsterScript.GetFinalPosition());
        // Debug.Log("Assigned " + currentMovement.name + " with duration " + randomDuration + " to " + monsterInRealGame.name);
    }


    
}
