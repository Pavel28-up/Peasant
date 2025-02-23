using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

// Скрипт для изминения и сохранения громкости звуков и фоновой музыки
public class MusicOption : MonoBehaviour
{
    // Переменные для слайдеров звука
    public Slider music;
    public Slider sound;

    private float musicValume = 100f;
    private float soundValume = 100f;

    void Awake()
    {
        musicValume = PlayerPrefs.GetFloat("ValumeMusic");
        soundValume = PlayerPrefs.GetFloat("ValumeSound");
    }

    void Start()
    {
        music.value = musicValume / 100;
        sound.value = soundValume / 100;
    }

    void Update()
    {
        musicValume = music.value;

        #region SAVEMUSICVALUME
        PlayerPrefs.SetFloat("ValumeMusic", musicValume * 100);
        #endregion

        SoundSystem.Instance.ToValumeMusic(musicValume * 100);

        soundValume = sound.value;

        #region SAVESOUNDVALUME
        PlayerPrefs.SetFloat("ValumeSound", soundValume * 100);
        #endregion

        SoundSystem.Instance.ToValumeSounds(soundValume * 100);
    }
}
