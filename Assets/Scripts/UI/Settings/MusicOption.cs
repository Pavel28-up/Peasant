using UnityEngine;
using UnityEngine.UI;

// ������ ��� ��������� � ���������� ��������� ������ � ������� ������
public class MusicOption : MonoBehaviour
{
    // ���������� ��� ��������� �����
    public Slider music;
    public Slider sound;

    // �������� ��������� ������ � ������
    private float musicValume = 100f;
    private float soundValume = 100f;

    void Awake()
    {
        // ��������� ������� ����� � ����������� ����������� ��������
        if (PlayerPrefs.HasKey("ValumeMusic"))
            musicValume = PlayerPrefs.GetFloat("ValumeMusic");
        // ���� ���� �� ������ ����������� �������� 
        else
            musicValume = 100f;

        // ��������� ������� ����� � ����������� ����������� ��������
        if (PlayerPrefs.HasKey("ValumeSound"))
            soundValume = PlayerPrefs.GetFloat("ValumeSound");
        // ���� ���� �� ������ ����������� ��������
        else
            soundValume = 100f;
    }

    void Start()
    {
        // ����������� �������� ���������� � ���
        music.value = musicValume;
        // ����������� �������� ���������� � ���
        sound.value = soundValume;
    }

    void Update()
    {
        // �������� �������� ����
        musicValume = music.value;

        #region SAVEMUSICVALUME
        // ��������� �������� ���������� �� 100
        PlayerPrefs.SetFloat("ValumeMusic", musicValume);
        #endregion

        SoundSystem.Instance.ToValumeMusic(musicValume);

        // �������� �������� ����
        soundValume = sound.value;

        #region SAVESOUNDVALUME
        // ��������� �������� ���������� �� 100
        PlayerPrefs.SetFloat("ValumeSound", soundValume);
        #endregion

        SoundSystem.Instance.ToValumeSounds(soundValume);
    }
}
