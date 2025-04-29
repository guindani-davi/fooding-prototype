using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    [SerializeField] private float topBound = 30f;
    [SerializeField] private float lowerBound = -10f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.z > topBound)
        {
            Destroy(gameObject);
        }
        else if (transform.position.z < lowerBound)
        {
            Destroy(gameObject);
        }
    }
}
