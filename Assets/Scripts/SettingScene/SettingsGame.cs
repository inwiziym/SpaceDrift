using UnityEngine;

public class SettingsGame : MonoBehaviour
{
    public void Start()
    {
        Application.targetFrameRate = 120;
        QualitySettings.vSyncCount = 1;
    }
}
