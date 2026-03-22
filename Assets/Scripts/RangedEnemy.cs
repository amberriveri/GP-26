using UnityEngine;

public class RangedEnemy : Enemy
{
    public GameObject projectile;

    public override void Attack()
    {
        Debug.Log("Ranged Enemy shoots!");

        Instantiate(projectile, transform.position + Vector3.forward, Quaternion.identity);
    }
}
