using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using TMPro;

public class UICombatText : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI contentText;
    [SerializeField] private Vector3 m_Offset;
    [SerializeField] private float m_EndOffsetY;
    [SerializeField] private float m_LifeTime;
 
    public void Setup(Vector3 position, string text, Color color)
    {
        transform.position = position + m_Offset;
        contentText.text = text;
        contentText.color = color;
        transform.DOMoveY(transform.position.y + m_EndOffsetY, m_LifeTime).OnComplete(SelfDespawn);
        contentText.DOFade(0, m_LifeTime);
    }

    private void SelfDespawn()
    {
        Destroy(gameObject);
    }
}
