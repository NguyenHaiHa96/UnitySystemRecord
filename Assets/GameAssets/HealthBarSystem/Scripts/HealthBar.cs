using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class HealthBar : MonoBehaviour
{
    [SerializeField] private Image imageFill;
    [SerializeField] private TextMeshProUGUI healthText;
    [SerializeField] private float health;
    [SerializeField] private float minHealth;
    [SerializeField] private float maxHealth;
    [SerializeField] private float currentHealth;
    [SerializeField] private float lerpSpeed;
    [SerializeField] private Gradient Color;

    public float Health { get => health; set => health = value; }

    public void OnInit(float minHealth, float maxHealth)
    {
        health = maxHealth;
        this.minHealth = minHealth;
        this.maxHealth = maxHealth;
        imageFill.fillAmount = 1;
        healthText.SetText($"{currentHealth}/{maxHealth}");
    }

    private void Update()
    {
        HandleHealthBar();
    }

    private void HandleHealthBar()
    {
        if (health == currentHealth) return;
        health = Mathf.Clamp(health, minHealth, maxHealth);
        currentHealth = Mathf.Lerp(currentHealth, health, lerpSpeed * Time.deltaTime);
        healthText.SetText($"{Mathf.RoundToInt(currentHealth)}/{maxHealth}");
        imageFill.fillAmount = currentHealth / maxHealth;
        imageFill.color = Color.Evaluate(imageFill.fillAmount);
    }
}

public enum EnemyType
{
    Grunt,
    Elite,
    Boss
}
