using UnityEngine;
using UnityEngine.UI;

public class LevelNumberUI : MonoBehaviour
{
    public Text levelNumberText;

    void Start()
    {
        levelNumberText.text = "L E V E L   " + PlayerStats.LevelNumber.ToString();
    }
}
