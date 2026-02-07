using UnityEngine;

public class CubeA : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.GetComponent<CubeB>())
        {
            GetComponent<Renderer>().material.color = Color.red;
        }
    }
}
