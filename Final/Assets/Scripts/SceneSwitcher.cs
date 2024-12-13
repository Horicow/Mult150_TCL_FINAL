using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SceneSwitcher : MonoBehaviour
{
    public Button yourButton;  // Reference to the button

    void Start()
    {
        if (yourButton != null)
        {
            yourButton.onClick.AddListener(SwitchScene);
        }
    }

    public void SwitchScene()
    {
        SceneManager.LoadScene("MainScene");  // Replace with your scene name
    }
}
