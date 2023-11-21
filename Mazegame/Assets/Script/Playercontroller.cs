using UnityEngine;

public class Playercontroller : MonoBehaviour
{
    public float speed = 0.1f; // ���ʳt��

    void Update()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, moveVertical, 0f) * speed * Time.deltaTime;

        transform.position += movement;
    }

    // �s�W���s�����k
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

    // ���򲾰ʤ@�q�ɶ�����k
    private System.Collections.IEnumerator MoveForSeconds(Vector3 direction)
    {
        float elapsedTime = 0f;
        float moveDuration = 0.1f; // ���ʫ���ɶ���3��

        while (elapsedTime < moveDuration)
        {
            transform.position += direction * speed * Time.deltaTime;
            elapsedTime += Time.deltaTime;
            yield return null;
        }
    }
}
