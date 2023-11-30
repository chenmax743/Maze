using UnityEngine;
using UnityEngine.UI;

public class ButtonDisappear : MonoBehaviour
{
    public Button targetButton; // 要消失的按鈕
    public Text targetText;

    void Start()
    {
        targetButton.onClick.AddListener(OnButtonClick);
    }

    void OnButtonClick()
    {
        targetButton.gameObject.SetActive(false); // 按下按鈕後，將按鈕物件設置為不可見
        targetText.gameObject.SetActive(false);
    }
}
