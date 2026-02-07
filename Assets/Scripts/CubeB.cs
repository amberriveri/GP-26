using System.Threading.Tasks;
using UnityEngine;

public class CubeB : MonoBehaviour
{
    public float hopForce = 5f;
    public float awayForce = 2f;

    private Rigidbody rb;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
        GetComponent<Collider>().isTrigger = true;
    }

    private async Task OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Vector3 away = transform.position - other.transform.position;
            away.y = 0f;
            away.Normalize();

            rb.AddForce(away * awayForce + Vector3.up * hopForce, ForceMode.Impulse);
        }
    }
}
