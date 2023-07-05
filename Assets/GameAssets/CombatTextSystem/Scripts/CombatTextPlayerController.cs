using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CombatTextPlayerController : MonoBehaviour
{
    [SerializeField] private int m_Health;
    [SerializeField] private int m_Speed;

    private void Update()
    {
        float vertical = Input.GetAxis("Vertical");
        float horizontal = Input.GetAxis("Horizontal");

        transform.position += new Vector3(horizontal, 0, vertical) * m_Speed * Time.deltaTime;
    }

    public void TakeDamage(int damage)
    {
        m_Health -= damage;
        CombatTextManager.instance.CreateUICombatText(transform.position, $"-{damage}", Color.red);
    }

    public void Heal(int value)
    {
        m_Health += value;
        CombatTextManager.instance.CreateUICombatText(transform.position, $"+{value}", Color.green);
    }
}
