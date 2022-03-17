using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;

public class VolumeControll : MonoBehaviour
{
    public AudioSource music;
    public Slider slider;
    public TextMeshProUGUI musicAmount;

    public void MusicSys()
    {
        music.volume = slider.value / 1;
        musicAmount.text = (slider.value * 100).ToString();
        double numara = Convert.ToDouble(musicAmount.text);
        if (numara < 10)
        {
            musicAmount.text = musicAmount.text[0] + "";
        }
        else if (numara == 100)
        {
            musicAmount.text = "100";
        }
        else
        {
            musicAmount.text = musicAmount.text[0] + "" + musicAmount.text[1];
        }

    }
}