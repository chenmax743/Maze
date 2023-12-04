using UnityEngine;
using UnityEngine.UI;

public class ObjectTextTouch : MonoBehaviour
{
    public Text textToDisplay; // �n��ܪ� UI ��r����
    public Button buttonToDisappearText; // �n������r�����s

    void Start()
    {
        textToDisplay.gameObject.SetActive(false); // ���ä�r
        buttonToDisappearText.gameObject.SetActive(false); // ���ë��s
        buttonToDisappearText.onClick.AddListener(ButtonClicked); // ��ť���s�I���ƥ�
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            textToDisplay.text = "Wait!"; // ��ܤ�r
            textToDisplay.gameObject.SetActive(true);
            buttonToDisappearText.gameObject.SetActive(true);
        }
    }

    void ButtonClicked()
    {
        textToDisplay.gameObject.SetActive(false); // ���U���s�����ä�r
        buttonToDisappearText.gameObject.SetActive(false);


    }
}
