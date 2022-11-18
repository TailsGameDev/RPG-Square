using UnityEngine;

public class DestroyItself : MonoBehaviour
{
    [SerializeField] private float lifeTime;

    private float timeOfDestruction;

    private void Awake()
    {
        timeOfDestruction = Time.time + lifeTime;
    }

    private void Update()
    {
        if (Time.time > timeOfDestruction)
        {
            Destroy(gameObject);
        }
    }
}
