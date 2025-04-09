using UnityEngine;

public class Pause : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))  // Можно использовать другую клавишу
        {
            if (Time.timeScale == 1)
            {
                Time.timeScale = 0;  // Пауза
            }
            else
            {
                Time.timeScale = 1;  // Возобновление
            }
        }
    }
}
