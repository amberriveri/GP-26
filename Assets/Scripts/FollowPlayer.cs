using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject player;

    //Set the camera's position
    public Vector3 offset = new Vector3(0f, 0f, -10f);

    void LateUpdate()
    {
        transform.position = player.transform.position + offset;
    }
}
