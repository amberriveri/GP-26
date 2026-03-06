using UnityEngine;

public class FindExample : MonoBehaviour
{
    public GameObject targetObject;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log("Found object: " + targetObject.name);
    }
}
