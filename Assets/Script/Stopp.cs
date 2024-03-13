using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stopp : MonoBehaviour
{
    private bool isPaused = false;

    // Hàm được gọi khi nút PauseButton được nhấn
    public void TogglePause()
    {
        // Đảo ngược trạng thái tạm dừng
        isPaused = !isPaused;

        // Nếu đang tạm dừng, dừng lại thời gian chạy
        if (isPaused)
        {
            Time.timeScale = 0;
            Debug.Log("Game Paused");
        }
        else
        {
            // Nếu không, tiếp tục thời gian chạy bình thường
            Time.timeScale = 1;
            Debug.Log("Game Unpaused");
        }
    }
}
