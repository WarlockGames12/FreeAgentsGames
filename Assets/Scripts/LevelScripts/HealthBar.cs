using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    public Slider Health;

    public void SetMaxHealth(int health)
    {
        Health.maxValue = health;
        Health.value = health;
    }

    public void SetHealth(int health)
    {
        Health.value = health;
    }
}
