using UnityEngine;

public class DetectCollisions : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("衝突検出: " + gameObject.name + " と " + other.gameObject.name);
        Destroy(gameObject);
        Destroy(other.gameObject);
    }
}
