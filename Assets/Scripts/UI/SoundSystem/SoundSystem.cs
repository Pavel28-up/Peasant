using UnityEngine;

// —крипт управл€ющий звуками
public class SoundSystem : MonoBehaviour
{
    public static SoundSystem Instance;

    public AudioSource clipMusic;

    [SerializeField] AudioClip ratchetButtonClip;
    AudioSource _ratchetButtonSound;

    // Start is called before the first frame update
    void Start()
    {
        if (Instance == null) Instance = this;
        else Destroy(this);

        _ratchetButtonSound = ConvertClipToConponent(ratchetButtonClip);

        ToValumeMusic(PlayerPrefs.GetFloat("ValumeMusic"));
        ToValumeSounds(PlayerPrefs.GetFloat("ValumeSound"));
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
        _ratchetButtonSound.PlayOneShot(ratchetButtonClip);
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
        _ratchetButtonSound.volume = volume / 100f;
    }
}
