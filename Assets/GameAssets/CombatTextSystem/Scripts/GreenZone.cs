using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GreenZone : MonoBehaviour
{
    [SerializeField] private int m_HealthAmount;
    [SerializeField] private float m_Duration;

    private float m_timer;

    private void OnTriggerStay(Collider other)
    {
        CollideWithPlayer(other);
    }

    private void CollideWithPlayer(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            m_timer -= Time.deltaTime;
            if (m_timer <= 0)
            {
                CombatTextPlayerController player = other.GetComponent<CombatTextPlayerController>();
                player.Heal(m_HealthAmount);
                m_timer = m_Duration;
            }
        }
    }
}

