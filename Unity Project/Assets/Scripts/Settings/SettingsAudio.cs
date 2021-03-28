﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SettingsAudio : MonoBehaviour
{
    /// <summary>
    /// Method subscribes to settings update event and loads the initial Maseter volume
    /// </summary>
    void Start()
    {
        GameEvents.current.onSettingsUpdate += updateVolume;
        AudioListener.volume = (float)(boot.bootObject.currentSettings.masterVolume) / 100f;
    }

    /// <summary>
    /// Method loads volume setting when the new settings event occurs
    /// </summary>
    private void updateVolume()
    {
        AudioListener.volume = (float)(boot.bootObject.currentSettings.masterVolume) / 100f;
    }
}
