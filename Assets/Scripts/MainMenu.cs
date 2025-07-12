using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{

    private bool mute;
    public Button volume;
    public Sprite muted;
    public Sprite unmuted;

    public void Awake()
    {
        mute = PlayerPrefs.GetInt("Mute") == 1 ? true : false;
    }

    public void PlayGame()
    {
        SceneManager.LoadSceneAsync(1);
    }

    public void MuteUnmute()
    {
        if (mute)
        {
            volume.image.sprite = unmuted;
        }
        else
        {
            volume.image.sprite = muted;
        }

        AudioListener.pause = !mute;

        mute = !mute;

        PlayerPrefs.SetInt("Mute", mute ? 1 : 0);
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
