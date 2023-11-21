using UnityEngine;
using UnityEngine.UI;

public class ChangeColorToggle : MonoBehaviour
{
    public Color newColor = Color.red; // �s���C��
    private Renderer objectRenderer; // ���󪺴�V��
    private bool colorChanged = false; // �C��O�_�w��諸�аO

    void Start()
    {
        objectRenderer = GetComponent<Renderer>(); // ���o���󪺴�V���ե�
    }

    public void ToggleObjectColor()
    {
        if (objectRenderer == null)
        {
            Debug.LogError("No Renderer component found!");
            return;
        }

        objectRenderer.material.color = colorChanged ? Color.white : newColor; // �����C��

        colorChanged = !colorChanged; // �����C�⪬�A
    }
}
