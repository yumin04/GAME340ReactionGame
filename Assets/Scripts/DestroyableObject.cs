using UnityEngine;

public abstract class DestroyableObject : MonoBehaviour
{
    protected virtual void Start()
    {
        GameEvents.DestroyMonsterAndTarget += this.DestroyCurrentObject;
    }
    public void DestroyCurrentObject()
    {
        Debug.Log("Destroy Called");
        Destroy(gameObject);
    }
}
