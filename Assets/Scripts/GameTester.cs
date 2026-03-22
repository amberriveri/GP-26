using UnityEngine;

public class GameTester : MonoBehaviour
{
    public MeleeEnemy melee;
    public RangedEnemy ranged;

    void Start()
    {
        melee.Attack();
        ranged.Attack();
    }
}
