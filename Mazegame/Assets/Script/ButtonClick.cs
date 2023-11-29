using UnityEngine;
using UnityEngine.UI;

public class ButtonClick : MonoBehaviour
{
    public Button displayButtonPrefab; // �n��ܪ����s�w�m��
    private Button instantiatedButton; // ��Ҥƫ᪺���s

    private void Start()
    {
        displayButtonPrefab.gameObject.SetActive(false); // ��l�Ʈ����ë��s
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            instantiatedButton = Instantiate(displayButtonPrefab, transform.position, Quaternion.identity);
            instantiatedButton.transform.SetParent(GameObject.Find("Canvas").transform, false);
            instantiatedButton.gameObject.SetActive(true);
            instantiatedButton.onClick.AddListener(ButtonClicked);
        }
    }

    void ButtonClicked()
    {
        Debug.Log("Button Clicked!");
    }
}
