using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace TopDownShooter
{
	public class HealthComponent : MonoBehaviour
	{
		private float m_health = 100;
		public GameObject panel;

		public void TakeDamage(float damage)
		{
			m_health = Mathf.Max(m_health - damage, 0f);

			if (m_health == 0)
			{
				PiayerCount.Deth -= 1;
				Destroy(gameObject);
				Time.timeScale = 0f;
			}
		}
	}
}