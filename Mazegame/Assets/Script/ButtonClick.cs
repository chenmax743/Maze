using UnityEngine;
using UnityEngine.UI;

public class ButtonClick : MonoBehaviour
{
    public Button displayButtonPrefab; // 要顯示的按鈕預置體
    private Button instantiatedButton; // 實例化後的按鈕

    private void Start()
    {
        displayButtonPrefab.gameObject.SetActive(false); // 初始化時隱藏按鈕
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
