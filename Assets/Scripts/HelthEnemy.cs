using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelthEnemy : MonoBehaviour
{
    public float helth;

    public void TakeHit(float damage)
    {
        helth -=  damage;

        if (helth <=0 )
        {
            EnemyCount.enemys += 1;
            Destroy(gameObject);
        }
    }

}
