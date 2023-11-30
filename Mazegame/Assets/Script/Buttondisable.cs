using UnityEngine;
using UnityEngine.UI;

public class Buttondisable : MonoBehaviour
{
    public Button[] buttons; // 所有按鈕的列表
    public GameObject targetObject; // 被碰撞的指定物件
    public Button targetButton; // 指定的按鈕

    private bool hasCollided = false;

    void OnCollisionEnter(Collision collision)
    {
        if (!hasCollided && collision.gameObject == targetObject)
        {
            hasCollided = true;

            foreach (Button button in buttons)
            {
                if (button != targetButton)
                {
                    button.gameObject.SetActive(false); // 碰撞到指定物件時，隱藏其他按鈕
                }
            }
        }
    }

    void Start()
    {
        targetButton.onClick.AddListener(EnableOtherButtons);
    }

    void EnableOtherButtons()
    {
        foreach (Button button in buttons)
        {
            if (button != targetButton)
            {
                button.gameObject.SetActive(true); // 點擊指定按鈕時，恢復其他按鈕
            }
        }
    }
}
