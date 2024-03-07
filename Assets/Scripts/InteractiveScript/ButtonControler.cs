using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonControler : MonoBehaviour
{
    public AudioSource audio;
    public GameObject playBtn;
    public GameObject pauseBtn;
    public GameObject resumeBtn;
    public GameObject replayBtn;
    // Start is called before the first frame update
    void Start()
    {
        playBtn.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        if (audio.time == audio.clip.length)
        {
            replayBtn.SetActive(false);
            pauseBtn.SetActive(false);
            resumeBtn.SetActive(false);
            playBtn.SetActive(true);
        }
    }
}
