using UnityEngine;

public class Playercontroller : MonoBehaviour
{
    public float speed = 0.1f; // 移動速度

    void Update()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, moveVertical, 0f) * speed * Time.deltaTime;

        transform.position += movement;
    }

    // 新增按鈕控制方法
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

    // 持續移動一段時間的方法
    private System.Collections.IEnumerator MoveForSeconds(Vector3 direction)
    {
        float elapsedTime = 0f;
        float moveDuration = 0.1f; // 移動持續時間為3秒

        while (elapsedTime < moveDuration)
        {
            transform.position += direction * speed * Time.deltaTime;
            elapsedTime += Time.deltaTime;
            yield return null;
        }
    }
}
