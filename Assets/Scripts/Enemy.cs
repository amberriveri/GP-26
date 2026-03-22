using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int health = 10;

    public virtual void Attack()
    {
        Debug.Log("Enemy attacks");
    }

    public void TakeDamage(int damage)
    {
        health -= damage;
        Debug.Log("Health: " + health);

        if (health <= 0)
        {
            Destroy(gameObject);
        }
    }
}
