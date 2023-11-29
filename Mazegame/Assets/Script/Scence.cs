using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Scence: MonoBehaviour
{
    public Button switchButton; // 切換場景的按鈕
    public string sceneToLoad; // 要切換到的場景名稱

    void Start()
    {
        switchButton.onClick.AddListener(SwitchScene);
    }

    void SwitchScene()
    {
        SceneManager.LoadScene(sceneToLoad);
    }
}
