using UnityEngine;

public class MeleeEnemy : Enemy
{
    public override void Attack()
    {
        Debug.Log("Melee enemy punches!");

        TakeDamage(2);
    }
}
