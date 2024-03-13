using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class HealthBar : MonoBehaviour
{
    public Slider slider;
    public float maxHealth = 1000f;
    private float currentHealth;

    void Start()
    {
        currentHealth = maxHealth;
        slider.maxValue = maxHealth;
        slider.value = maxHealth;
    }

    void Update()
    {
        // Giảm dần thanh máu theo thời gian
        //currentHealth -= Time.deltaTime;
        slider.value = currentHealth;

        // Khi thanh máu hết, kết thúc game
        if (currentHealth <= 0)
        {
            EndGame();
        }
    }

    // Hàm này để xử lý khi nhận va chạm
    public void TakeDamage(float damage)
    {
        currentHealth -= damage;
        slider.value = currentHealth;

        if (currentHealth <= 0)
        {
            EndGame();
        }
    }

    void EndGame()
    {
        
        SceneManager.LoadScene("Menu");
    }
}