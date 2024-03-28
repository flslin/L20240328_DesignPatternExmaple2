using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// ���� ��ü�� ����
public class WeaponMove : MonoBehaviour
{
    [SerializeField][Range(5, 10)]float speed = 10.0f;

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.up * speed * Time.deltaTime);

        if (transform.position.y > 10.0f)
            Destroy(gameObject);
    }
}
