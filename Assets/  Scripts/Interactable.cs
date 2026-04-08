using UnityEngine;

public class Interactable : MonoBehaviour
{
    public string message = "God is with you.";

    void OnMouseDown()
    {
        Debug.Log(message);
    }
}
