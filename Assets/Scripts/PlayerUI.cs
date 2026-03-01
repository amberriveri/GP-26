using UnityEngine;

public class PlayerUI : MonoBehaviour
{
    public PlayerHealth playerHealth;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.H))
        {
            playerHealth.TakeDamage(10);
        }

        if (Input.GetKeyDown(KeyCode.G))
        {
            playerHealth.Heal(10);
        }
    }
}
