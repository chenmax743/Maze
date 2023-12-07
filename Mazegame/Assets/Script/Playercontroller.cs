using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 0.1f; // 移動速度
    private Vector3 originalScale; // 初始縮放比例

    void Start()
    {
        // 保存初始縮放比例
        originalScale = transform.localScale;
    }

    void Update()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, moveVertical, 0f) * speed * Time.deltaTime;

        // 移動玩家
        transform.position += movement;

        // 根據移動方向翻轉玩家的圖片
        FlipImage(moveHorizontal);
    }

    // 移動指令
    public void MoveRightButton()
    {
        StartCoroutine(MoveForSeconds(Vector3.right));
    }

    public void MoveLeftButton()
    {
        StartCoroutine(MoveForSeconds(Vector3.left));
    }

    public void MoveUpButton()
    {
        StartCoroutine(MoveForSeconds(Vector3.up));
    }

    public void MoveDownButton()
    {
        StartCoroutine(MoveForSeconds(Vector3.down));
    }

    // 移動指定秒數
    private System.Collections.IEnumerator MoveForSeconds(Vector3 direction)
    {
        float elapsedTime = 0f;
        float moveDuration = 0.1f; // 移動持續時間為0.1秒

        while (elapsedTime < moveDuration)
        {
            // 移動玩家
            transform.position += direction * speed * Time.deltaTime;

            // 根據移動方向翻轉玩家的圖片
            FlipImage(direction.x);

            elapsedTime += Time.deltaTime;
            yield return null;
        }

        // 確保在移動後圖片的方向正確
        FlipImage(direction.x);
    }

    // 圖片翻轉
    private void FlipImage(float moveHorizontal)
    {
        // 如果向左移動，水平翻轉圖片
        if (moveHorizontal < 0)
        {
            transform.localScale = new Vector3(-originalScale.x, originalScale.y, originalScale.z);
        }
        // 如果向右移動，保持原始縮放比例
        else if (moveHorizontal > 0)
        {
            transform.localScale = originalScale;
        }
    }
}
