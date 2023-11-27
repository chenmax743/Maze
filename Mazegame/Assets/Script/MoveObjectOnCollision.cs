using UnityEngine;

public class MoveObjectOnCollision : MonoBehaviour
{
    public GameObject objectToMove; // �n���ʪ�����
    public float moveSpeed = 5f; // ���ʳt��
    public float moveDuration = 3f; // ���ʮɶ�

    private bool hasCollided = false;

    void Update()
    {
        if (hasCollided)
        {
            // �V�k���ʪ��� B
            objectToMove.transform.Translate(Vector2.right * moveSpeed * Time.deltaTime);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (!hasCollided && collision.gameObject != objectToMove)
        {
            // �I����}�l���ʪ��� B
            hasCollided = true;
            StartCoroutine(MoveForDuration());
        }
    }

    // ��{�G���ʤ@�q�ɶ��ᰱ��
    private System.Collections.IEnumerator MoveForDuration()
    {
        yield return new WaitForSeconds(moveDuration);
        hasCollided = false; // �����
    }
}
