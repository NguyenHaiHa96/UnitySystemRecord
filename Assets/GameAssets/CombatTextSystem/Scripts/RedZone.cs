using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedZone : MonoBehaviour
{
    [SerializeField] private int m_FirstDamageTaken;
    [SerializeField] private int m_DurationDamageTaken;
    [SerializeField] private float m_Duration;

    private float m_timer;

    private void Start()
    {
        m_timer = m_Duration;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            CombatTextPlayerController player = other.GetComponent<CombatTextPlayerController>();
            player.TakeDamage(m_FirstDamageTaken);
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            m_timer -= Time.deltaTime;
            if (m_timer <= 0)
            {
                CombatTextPlayerController player = other.GetComponent<CombatTextPlayerController>();
                player.TakeDamage(m_DurationDamageTaken);
                m_timer = m_Duration;
            }
        }
    }
}
