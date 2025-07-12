using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InputManager : MonoBehaviour
{

    private bool mute;
    public Button volume;
    public Sprite muted;
    public Sprite unmuted;

    private bool pause = false;

    public GameObject pausePanel;

    private PlayerController playerController;

    [HideInInspector] public float vertical, horizontal;

    public void Awake()
    {
        mute = PlayerPrefs.GetInt("Mute") == 1 ? true : false;
    }

    // Start is called before the first frame update
    void Start()
    {
        playerController = GetComponent<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {
        vertical = Input.GetAxis("Vertical");
        horizontal = Input.GetAxis("Horizontal");

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            PauseUnpause();
        }
    }

    public void PauseUnpause()
    {
        pause = !pause;

        if (pause)
        {
            Time.timeScale = 0;
            pausePanel.SetActive(true);
            playerController.cursorLocked = false;
        } 
        else
        {
            Time.timeScale = 1;
            pausePanel.SetActive(false);
            playerController.cursorLocked = true;
        }
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
