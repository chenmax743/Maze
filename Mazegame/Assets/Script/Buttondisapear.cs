using UnityEngine;
using UnityEngine.UI;

public class ButtonDisappear : MonoBehaviour
{
    public Button targetButton; // �n���������s
    public Text targetText;

    void Start()
    {
        targetButton.onClick.AddListener(OnButtonClick);
    }

    void OnButtonClick()
    {
        targetButton.gameObject.SetActive(false); // ���U���s��A�N���s����]�m�����i��
        targetText.gameObject.SetActive(false);
    }
}
