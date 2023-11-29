using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Scence: MonoBehaviour
{
    public Button switchButton; // �������������s
    public string sceneToLoad; // �n�����쪺�����W��

    void Start()
    {
        switchButton.onClick.AddListener(SwitchScene);
    }

    void SwitchScene()
    {
        SceneManager.LoadScene(sceneToLoad);
    }
}
