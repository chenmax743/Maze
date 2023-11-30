using UnityEngine;
using UnityEngine.UI;

public class DestroyButton : MonoBehaviour
{
    private Button button;

    private void Start()
    {
        // 取得按鈕元件
        button = GetComponent<Button>();

        // 添加按下按鈕後的函式作為監聽器
        button.onClick.AddListener(DestroyThisButton);
    }

    private void OnDestroy()
    {
        // 確保在物件被摧毀時移除監聽器，避免產生不必要的錯誤
        if (button != null)
        {
            button.onClick.RemoveListener(DestroyThisButton);
        }
    }

    private void DestroyThisButton()
    {
        // 摧毀該按鈕物件
        Destroy(gameObject);
    }
}
