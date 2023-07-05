using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CombatTextManager : MonoBehaviour
{
    public static CombatTextManager instance;
    [SerializeField] private UICombatText m_UICombatTextPrefab;
    [SerializeField] private Transform m_CanvasCombatText;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else if (instance != this)
        {
            Destroy(gameObject);
        }
    }

    public void CreateUICombatText(Vector3 position, string text, Color color)
    {
        UICombatText uiCombatText = Instantiate(m_UICombatTextPrefab, m_CanvasCombatText);
        uiCombatText.Setup(position, text, color);
    }
}
