using UnityEngine;
using UnityEngine.UI;

public class DisplayTextOnCollision : MonoBehaviour
{
    public string displayText = "Hello, World!"; // 要顯示的文字
    public Text displayUIText; // 引用 Text 元件

    private void Start()
    {
        displayUIText.text = ""; // 清空 Text 元件的文字
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            displayUIText.text = displayText; // 將文字設置到 Text 元件上
        }
    }
}
