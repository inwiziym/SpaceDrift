using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterPlayer : MonoBehaviour
{
    public float moveDistanceY; // ���������� ����������� ������� �� Y
    private bool isMoving = false; // ���� ��� �����������, �������� �� ������� � ������ ������
    private float targetY; // Y-����������, � ������� ������� ������ �������������
    public float moveSpeed = 5f; // �������� ����������� ������� �����

    void Update()
    {
        if (Input.touchCount > 0) // ���������, ���� �� ������� ������
        {
            Touch touch = Input.GetTouch(0); // �������� ���������� � ������ �������
            if (touch.phase == TouchPhase.Began) // ���� ��� ������ �������
            {
                targetY = transform.position.y + moveDistanceY; // ��������� ������� Y-���������� ��� ����������� �����
                isMoving = true; // ������������� ���� �������� � true
            }
        }

        if (isMoving)
        {
            // ���������� ������� � ������� Y-���������� � ������� ������ MoveTowards
            transform.position = new Vector3(transform.position.x, Mathf.MoveTowards(transform.position.y, targetY, moveDistanceY * Time.deltaTime), transform.position.z);

            // ���������, ������ �� ������� ������� Y-����������
            if (Mathf.Approximately(transform.position.y, targetY))
            {
                isMoving = false; // ����� ������� ��������� Y-����������, ��������� ���� ��������
            }
        }

        // ���������� ������� ����� �� ��� Y � ���������� ���������
        transform.position = new Vector3(transform.position.x, transform.position.y + moveSpeed * Time.deltaTime, transform.position.z);
    }
}
