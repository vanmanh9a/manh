using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageOnCollision : MonoBehaviour
{
    public HealthBar healthBar;
    private float damageAmount = 1f;

    /*void OnCollisionStay(Collision collision)
    {
        // Xác định logic va chạm và gọi hàm TakeDamage()
        if (collision.gameObject.tag == "Enemy")
        {
            healthBar.TakeDamage(damageAmount);
        }
    }*/


    void OnTriggerStay(Collider other)
    {
        {
            // Xác định logic va chạm và gọi hàm TakeDamage()
            if (other.gameObject.tag == "Enemy")
            {
                healthBar.TakeDamage(damageAmount);
            }
        }
    }
}