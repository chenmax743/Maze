using UnityEngine;
using UnityEngine.UI;

public class ChangeColorToggle : MonoBehaviour
{
    public Color newColor = Color.red; // 新的顏色
    private Renderer objectRenderer; // 物件的渲染器
    private bool colorChanged = false; // 顏色是否已更改的標記

    void Start()
    {
        objectRenderer = GetComponent<Renderer>(); // 取得物件的渲染器組件
    }

    public void ToggleObjectColor()
    {
        if (objectRenderer == null)
        {
            Debug.LogError("No Renderer component found!");
            return;
        }

        objectRenderer.material.color = colorChanged ? Color.white : newColor; // 切換顏色

        colorChanged = !colorChanged; // 切換顏色狀態
    }
}
