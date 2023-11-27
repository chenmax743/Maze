using UnityEngine;

public class MoveObjectOnCollision : MonoBehaviour
{
    public GameObject objectToMove; // 要移動的物件
    public float moveSpeed = 5f; // 移動速度
    public float moveDuration = 3f; // 移動時間

    private bool hasCollided = false;

    void Update()
    {
        if (hasCollided)
        {
            // 向右移動物件 B
            objectToMove.transform.Translate(Vector2.right * moveSpeed * Time.deltaTime);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (!hasCollided && collision.gameObject != objectToMove)
        {
            // 碰撞後開始移動物件 B
            hasCollided = true;
            StartCoroutine(MoveForDuration());
        }
    }

    // 協程：移動一段時間後停止
    private System.Collections.IEnumerator MoveForDuration()
    {
        yield return new WaitForSeconds(moveDuration);
        hasCollided = false; // 停止移動
    }
}
