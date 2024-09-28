using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerHealth : MonoBehaviour
{
    [SerializeField] float hitPoints = 100f;
    [SerializeField] TextMeshProUGUI healthText;
    private void Update()
    {
        healthText.text = hitPoints.ToString();
        if (hitPoints <= 30)
            healthText.color = Color.red;
    }
    public void TakeDamage(float damage)
    {
        hitPoints -= damage;
        if (hitPoints <= 0)
        {
            hitPoints = 0;
            GetComponent<DeathHandler>().HandleDeath();
        }
    }
}
