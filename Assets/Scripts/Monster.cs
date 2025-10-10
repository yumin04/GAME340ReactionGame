using UnityEngine;
using MonsterMovement;
using Unity.VisualScripting;

public class Monster : DestroyableObject
{

    
    private IObjectMovement movementSO;
    private float maximumTime;
    
    private float moveDistance = 3f;
    private float elapsed;
    
    
    public void SetMovement(IObjectMovement movement, float randomDuration)
    {
        movementSO = movement;
        maximumTime = randomDuration;
    }

    public Vector3 GetFinalPosition()
    {
        float curveValue = movementSO.ReturnCalculatedPosition(1);

        return CalculaltePosition(curveValue);
    }

    protected override void Start()
    {
        transform.position = new Vector3(0, 4, 0);
        base.Start();
    }
    void Update()
    {
        
        elapsed += Time.deltaTime;
        float ratio = Mathf.Clamp01(elapsed / maximumTime);

        float curveValue = movementSO.ReturnCalculatedPosition(ratio);

        transform.position += CalculaltePosition(curveValue);
        

        if (elapsed >= maximumTime + 3f)
        {
            DestroyCurrentObject();
        }
    }

    private Vector3 CalculaltePosition(float value)
    {
        return new Vector3(0, -1 * value * moveDistance, 0);
    }
}
