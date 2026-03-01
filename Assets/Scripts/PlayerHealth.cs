using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    private int health = 100;

    public void TakeDamage(int amount)
    {
        health -= amount;
        Debug.Log("Player took damage. Health: " + health);
    }

    public void Heal(int amount)
    {
        if (health < 100)
        {
            health += amount;
            Debug.Log("Player healed. Health: " + health);
        }
    }
}