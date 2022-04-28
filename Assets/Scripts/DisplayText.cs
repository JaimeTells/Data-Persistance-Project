using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class DisplayText : MonoBehaviour
{
    public Text Text;
    public InputField display;
    public Text highScore;
    // Start is called before the first frame update
    void Start()
    {
        Text.text = PlayerPrefs.GetString("user_name");
        highScore.text = $"{Text.text} : {PlayerPrefs.GetInt("HighScore", 0).ToString()}";
    }

    public void Create()
    {
        Text.text = display.text;
        PlayerPrefs.SetString("user_name", Text.text);
        PlayerPrefs.Save();
    }
}
