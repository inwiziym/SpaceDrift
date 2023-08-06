using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class SettingsSceneManager : MonoBehaviour
{
    public int LoadLevel;
    public int RestartLevel;

    public void LoadLevels()
    {
        SceneManager.LoadScene(LoadLevel);
    }

    public void RestartScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    public void QuitGame()
    {
        Application.Quit();
    }
    //���� ��� ��� ������
    //public Slider swipeSlider;
    //public float swipeThreshold = 50f; // ����������� �������� ������ ��� �������� �� ����� �������

    //private Vector2 startPos;
    //private Vector2 endPos;

    //private void Update()
    //{
    //    if (Input.touchCount > 0)
    //    {
    //        Touch touch = Input.GetTouch(0);

    //        if (touch.phase == TouchPhase.Began)
    //        {
    //            startPos = touch.position;
    //        }
    //        else if (touch.phase == TouchPhase.Ended)
    //        {
    //            endPos = touch.position;

    //            float swipeValue = (endPos.y - startPos.y) / Screen.height * 100f;

    //            if (Mathf.Abs(swipeValue) >= swipeThreshold)
    //            {
    //                if (swipeValue > 0) // ����� �����
    //                {
    //                    LoadSceneIndex();
    //                }
    //            }
    //            swipeSlider.value = 0;
    //        }
    //    }
    //}
}
