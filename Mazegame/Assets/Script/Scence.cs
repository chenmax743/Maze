using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneSwitcher : MonoBehaviour
{
    public Button switchButton; // 切換場景的按鈕
    public string sceneToLoad; // 要加載的目標場景名稱

    void Start()
    {
        // 在開始時，綁定按鈕點擊事件到 SwitchScene 方法
        switchButton.onClick.AddListener(SwitchScene);
    }

    void SwitchScene()
    {
        // 調用 SceneManager.LoadScene 方法以加載指定的場景
        SceneManager.LoadScene(sceneToLoad);
    }
}
