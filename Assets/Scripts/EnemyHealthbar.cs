using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyHealthbar : MonoBehaviour
{
    public Slider slider;
    public Gradient gradient;
    public Image fill;

    public void SetMaxHealth(int Leben)
    {
        slider.maxValue = Leben;
        slider.value = Leben;

        fill.color = gradient.Evaluate(1f);
    }
    public void SetHealth(int Health)
    {
        slider.value = Health;
        fill.color = gradient.Evaluate(slider.normalizedValue);
    }
}
