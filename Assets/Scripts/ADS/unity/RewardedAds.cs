using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Advertisements;

public class RewardedAds : MonoBehaviour, IUnityAdsLoadListener, IUnityAdsShowListener
{
    [SerializeField] public Button buttonShowAd;

    [SerializeField] private string androidAdID = "Rewarded_Android";
    [SerializeField] private string iOSAdID = "Rewarded_iOS";

    [SerializeField] private string adID;

    private void Awake()
    {
        adID = (Application.platform == RuntimePlatform.IPhonePlayer)
            ? iOSAdID
            : androidAdID;

        // buttonShowAd.interactable = false;
    }

    private void Start()
    {
        LoadAd();
    }

    public void LoadAd()
    {
        // Debug.Log("Loading Ad: " + adID);
        Advertisement.Load(adID, this);
    }

    public void ShowAd()
    {
        Advertisement.Show(adID, this);

        buttonShowAd.interactable = false;
    }

    public void OnUnityAdsAdLoaded(string adUnitId)
    {
        // Debug.Log("Ad Loaded: " + adUnitId);

        if (adUnitId.Equals(adID))
        {
            buttonShowAd.onClick.AddListener(ShowAd);

            buttonShowAd.interactable = true;
        }
    }

    public void OnUnityAdsFailedToLoad(string placementId, UnityAdsLoadError error, string message)
    {
        // Debug.Log($"Error loading Ad Unit {adID}: {error.ToString()} - {message}");
    }

    public void OnUnityAdsShowFailure(string placementId, UnityAdsShowError error, string message)
    {
        // Debug.Log($"Error showing Ad Unit {adID}: {error.ToString()} - {message}");
    }

    public void OnUnityAdsShowStart(string placementId)
    {
    }

    public void OnUnityAdsShowClick(string placementId)
    {
    }

    public void OnUnityAdsShowComplete(string adUnitId, UnityAdsShowCompletionState showCompletionState)
    {
        if (adUnitId.Equals(adID) && showCompletionState.Equals(UnityAdsShowCompletionState.COMPLETED))
        {

            // Debug.Log("Unity Ads Rewarded Ad Completed");
        }
    }
    private void OnDestroy()
    {
        buttonShowAd.onClick.RemoveAllListeners();
    }
}
