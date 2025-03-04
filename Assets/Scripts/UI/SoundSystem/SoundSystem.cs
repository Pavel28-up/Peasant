using UnityEngine;

// —крипт управл€ющий звуками
public class SoundSystem : MonoBehaviour
{
    public static SoundSystem Instance;

    public AudioSource clipMusic;

    [SerializeField] AudioClip buttonClip;
    AudioSource _buttonSound;

    // Start is called before the first frame update
    void Start()
    {
        if (Instance == null) Instance = this;
        else Destroy(this);

        OnEnable();

        if (buttonClip)
            _buttonSound = ConvertClipToConponent(buttonClip);

        if (PlayerPrefs.HasKey("ValumeMusic"))
            ToValumeMusic(PlayerPrefs.GetFloat("ValumeMusic"));

        if (PlayerPrefs.HasKey("ValumeSound"))
        {
            if (buttonClip)
            {
                Debug.Log("Sound");
                ToValumeSounds(PlayerPrefs.GetFloat("ValumeSound"));
            }
        }
    }

    private void OnEnable()
    {
        GameEvents.Instance.OnButton += PlayRatchetButton;
    }

    private void OnDisable()
    {
        GameEvents.Instance.OnButton -= PlayRatchetButton;
    }

    private void PlayRatchetButton()
    {
        Debug.Log("sound");
        if (buttonClip)
            _buttonSound.PlayOneShot(buttonClip);
    }

    private AudioSource ConvertClipToConponent(AudioClip clipToConvert)
    {
        AudioSource shootingSource = gameObject.AddComponent<AudioSource>();
        shootingSource.clip = clipToConvert;
        shootingSource.playOnAwake = false;
        shootingSource.volume = 1f;
        return shootingSource;
    }

    public void ToValumeMusic(float volume)
    {
        clipMusic.volume = volume / 100f;
    }

    public void ToValumeSounds(float volume)
    {
        //Debug.Log(volume);
        _buttonSound.volume = volume / 100f;
    }
}
