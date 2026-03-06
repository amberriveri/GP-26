using UnityEngine;

public class FindExample2 : MonoBehaviour
{
    GameObject targetObject;

    void Start()
    {
        targetObject = GameObject.Find("Cube");
        Debug.Log("Found object: " + targetObject.name);

        targetObject.SetActive(false);
    }
}
