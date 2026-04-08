using UnityEngine;

public class CollectibleScroll : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            Debug.Log("Scroll Collected!");
            Destroy(gameObject);
        }
    }
}
