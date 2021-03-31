using UnityEngine;
using System.Collections;

public class Settings
{


    public int HighScore { get; set; }

    public void Load(AudioSource music, AudioSource sound)
    {


        HighScore = PlayerPrefs.GetInt("HighScore", 0);
    }

    public void Save()
    {
       PlayerPrefs.SetInt("HighScore", HighScore);
    }
}
