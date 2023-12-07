using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneSwitcher1 : MonoBehaviour
{
    public string sceneToLoad; // 要加载的目标场景名称

    void OnTriggerEnter2D(Collider2D other)
    {
        // 检测碰撞的对象是否具有 "Player" 标签
        if (other.CompareTag("Player"))
        {
            // 调用 SwitchScene 方法切换场景
            SwitchScene();
        }
    }

    void SwitchScene()
    {
        // 调用 SceneManager.LoadScene 方法以加载指定的场景
        SceneManager.LoadScene(sceneToLoad);
    }
}
