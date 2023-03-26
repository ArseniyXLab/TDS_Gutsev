using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TopDownShooter
{
	public class AttackManager : MonoBehaviour
	{
		[SerializeField] private AttackComponent m_weapon2;
		[SerializeField] private AttackComponent m_weapon1;

		public void Attack()
		{
			m_weapon1.Attack();
			m_weapon2.Attack();
		}
	}
}