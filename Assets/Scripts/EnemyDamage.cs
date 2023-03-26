using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDamage : MonoBehaviour
{
    [SerializeField] private float m_damage = 50f;
    [SerializeField] private string collisionTag;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == collisionTag)
        {
            var health = collision.gameObject.GetComponentInParent<TopDownShooter.HealthComponent>();
            if (health)
            {
                health.TakeDamage(m_damage);
            }
        }
    }
}
