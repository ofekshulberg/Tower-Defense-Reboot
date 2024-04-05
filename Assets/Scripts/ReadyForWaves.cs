using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class ReadyForWaves : MonoBehaviour
{
    public GameObject readyCanvas;

    public WaveSpawner waveSpawner;

    private void Awake()
    {
        readyCanvas.SetActive(true);
    }

    public void Ready()
    {
        waveSpawner.enabled = true;
        readyCanvas.SetActive(false);
    }
}
