using UnityEngine;
using UnityEngine.UI;

// Скрипт для изминения и сохранения громкости звуков и фоновой музыки
public class MusicOption : MonoBehaviour
{
    // Переменные для слайдеров звука
    public Slider music;
    public Slider sound;

    // Значение громкости музики и звуков
    private float musicValume = 100f;
    private float soundValume = 100f;

    void Awake()
    {
        // Проверяем наличия ключа и присваеваем сохраненное значение
        if (PlayerPrefs.HasKey("ValumeMusic"))
            musicValume = PlayerPrefs.GetFloat("ValumeMusic");
        // Если ключ не найден присваеваем значение 
        else
            musicValume = 100f;

        // Проверяем наличия ключа и присваеваем сохраненное значение
        if (PlayerPrefs.HasKey("ValumeSound"))
            soundValume = PlayerPrefs.GetFloat("ValumeSound");
        // Если ключ не найден присваеваем значение
        else
            soundValume = 100f;
    }

    void Start()
    {
        // Присваеваем значение переменной в бар
        music.value = musicValume;
        // Присваеваем значение переменной в бар
        sound.value = soundValume;
    }

    void Update()
    {
        // Получаем значение бара
        musicValume = music.value;

        #region SAVEMUSICVALUME
        // Сохраняем значение умноженное на 100
        PlayerPrefs.SetFloat("ValumeMusic", musicValume);
        #endregion

        SoundSystem.Instance.ToValumeMusic(musicValume);

        // Получаем значение бара
        soundValume = sound.value;

        #region SAVESOUNDVALUME
        // Сохраняем значение умноженное на 100
        PlayerPrefs.SetFloat("ValumeSound", soundValume);
        #endregion

        SoundSystem.Instance.ToValumeSounds(soundValume);
    }
}
