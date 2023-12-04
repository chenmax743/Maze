using UnityEngine;
using UnityEngine.UI;

public class ObjectTextTouch : MonoBehaviour
{
    public Text textToDisplay; // 要顯示的 UI 文字元件
    public Button buttonToDisappearText; // 要消失文字的按鈕

    void Start()
    {
        textToDisplay.gameObject.SetActive(false); // 隱藏文字
        buttonToDisappearText.gameObject.SetActive(false); // 隱藏按鈕
        buttonToDisappearText.onClick.AddListener(ButtonClicked); // 監聽按鈕點擊事件
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            textToDisplay.text = "Wait!"; // 顯示文字
            textToDisplay.gameObject.SetActive(true);
            buttonToDisappearText.gameObject.SetActive(true);
        }
    }

    void ButtonClicked()
    {
        textToDisplay.gameObject.SetActive(false); // 按下按鈕後隱藏文字
        buttonToDisappearText.gameObject.SetActive(false);


    }
}
