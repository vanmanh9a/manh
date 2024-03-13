using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class QuitMenu : MonoBehaviour
{
    // Start is called before the first frame update
    public void BackToMenuButtonClicked()
    {
        SceneManager.LoadScene("Menu"); // Thay "MainMenu" bằng tên của Scene chứa menu chính của bạn
    }
}