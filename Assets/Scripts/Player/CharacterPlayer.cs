using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterPlayer : MonoBehaviour
{
    public float moveDistanceY; // Расстояние перемещения корабля по Y
    private bool isMoving = false; // Флаг для определения, движется ли корабль в данный момент
    private float targetY; // Y-координата, к которой корабль должен переместиться
    public float moveSpeed = 5f; // Скорость перемещения корабля вверх

    void Update()
    {
        if (Input.touchCount > 0) // Проверяем, было ли касание экрана
        {
            Touch touch = Input.GetTouch(0); // Получаем информацию о первом касании
            if (touch.phase == TouchPhase.Began) // Если это начало касания
            {
                targetY = transform.position.y + moveDistanceY; // Вычисляем целевую Y-координату для перемещения вверх
                isMoving = true; // Устанавливаем флаг движения в true
            }
        }

        if (isMoving)
        {
            // Перемещаем корабль к целевой Y-координате с помощью метода MoveTowards
            transform.position = new Vector3(transform.position.x, Mathf.MoveTowards(transform.position.y, targetY, moveDistanceY * Time.deltaTime), transform.position.z);

            // Проверяем, достиг ли корабль целевой Y-координаты
            if (Mathf.Approximately(transform.position.y, targetY))
            {
                isMoving = false; // Когда корабль достигает Y-координаты, отключаем флаг движения
            }
        }

        // Перемещаем корабль вверх по оси Y с постоянной скоростью
        transform.position = new Vector3(transform.position.x, transform.position.y + moveSpeed * Time.deltaTime, transform.position.z);
    }
}
