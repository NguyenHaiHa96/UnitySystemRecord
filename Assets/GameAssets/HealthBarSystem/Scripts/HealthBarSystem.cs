using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthBarSystem : MonoBehaviour
{
    [SerializeField] private HealthBar healthBar;

    private void Start()
    {
        healthBar.OnInit(0, 100);
    }

    public void IncreaseHealth(float value)
    {
        healthBar.Health += value;
    }

    public void DecreaseHealth(float value) 
    {  
        healthBar.Health -= value;
    }
}
