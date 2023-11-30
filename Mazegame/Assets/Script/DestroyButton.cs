using UnityEngine;
using UnityEngine.UI;

public class DestroyButton : MonoBehaviour
{
    private Button button;

    private void Start()
    {
        // ���o���s����
        button = GetComponent<Button>();

        // �K�[���U���s�᪺�禡�@����ť��
        button.onClick.AddListener(DestroyThisButton);
    }

    private void OnDestroy()
    {
        // �T�O�b����Q�R���ɲ�����ť���A�קK���ͤ����n�����~
        if (button != null)
        {
            button.onClick.RemoveListener(DestroyThisButton);
        }
    }

    private void DestroyThisButton()
    {
        // �R���ӫ��s����
        Destroy(gameObject);
    }
}
