using UnityEngine;
using UnityEngine.UI;

public class Buttondisable : MonoBehaviour
{
    public Button[] buttons; // �Ҧ����s���C��
    public GameObject targetObject; // �Q�I�������w����
    public Button targetButton; // ���w�����s

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
                    button.gameObject.SetActive(false); // �I������w����ɡA���è�L���s
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
                button.gameObject.SetActive(true); // �I�����w���s�ɡA��_��L���s
            }
        }
    }
}
