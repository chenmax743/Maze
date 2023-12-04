using UnityEngine;
using UnityEngine.UI;

public class ChangeImageOnButtonPress : MonoBehaviour
{
    public Sprite[] images; // 圖片陣列
    public Button[] changeButtons; // 多個更換圖片的按鈕

    private SpriteRenderer objectSpriteRenderer; // 圖片渲染器
    private int currentImageIndex = 0; // 當前圖片索引

    void Start()
    {
        objectSpriteRenderer = GetComponent<SpriteRenderer>(); // 取得物件的 SpriteRenderer

        foreach (Button button in changeButtons)
        {
            button.onClick.AddListener(() => ChangeImage()); // 將多個按鈕連接到不同的方法
        }
    }

    void ChangeImage()
    {
        if (currentImageIndex < images.Length) // 檢查索引是否在圖片陣列範圍內
        {
            objectSpriteRenderer.sprite = images[currentImageIndex]; // 更換圖片為索引處的圖片
            currentImageIndex++; // 移動到下一張圖片
        }
        else
        {
            currentImageIndex = 0; // 如果到達最後一張圖片，重新從第一張開始
        }
    }
}
