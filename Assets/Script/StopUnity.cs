using UnityEditor;
using UnityEngine;

namespace UnityEditor
{
    public class StopUnity : MonoBehaviour
    {
        // Call this method to quit the game
        public void QuitGame()
        {
#if UNITY_EDITOR
            // If in the Unity Editor, stop playing the game
            UnityEditor.EditorApplication.isPlaying = false;
#else
        // If in a build, quit the application
        Application.Quit();
#endif
        }
    }
}
