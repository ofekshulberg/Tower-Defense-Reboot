using UnityEngine;

public class CompleteLevel : MonoBehaviour
{
    public string menuSceneName = "MainMenu";

    public string nextLevel = "Level2";
    public int levelToUnlock = 2;

    public SceneFader sceneFader;

    public GameObject changingNumberaCanvas;

    void Start()
    {
        changingNumberaCanvas.SetActive(false);
    }

    public void Continue()
    {
        PlayerPrefs.SetInt("levelReahced", levelToUnlock);
        sceneFader.FadeTo(nextLevel);
        changingNumberaCanvas.SetActive(true);
    }

    public void Menu()
    {
        sceneFader.FadeTo(menuSceneName);
    }
}
