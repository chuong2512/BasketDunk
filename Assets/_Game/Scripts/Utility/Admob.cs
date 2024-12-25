
using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Admob : Singleton<Admob>
{
    [Header("Admob Ad Units :")]
    // Test App Id = "ca-app-pub-3940256099942544~3347511713";
    [SerializeField] [TextArea(1, 2)] string idBanner = "ca-app-pub-3940256099942544/6300978111";
    [SerializeField] [TextArea(1, 2)] string idInterstitial = "ca-app-pub-3940256099942544/1033173712";
    [SerializeField] [TextArea(1, 2)] string idReward = "ca-app-pub-3940256099942544/5224354917";

    [Header("Toggle Admob Ads :")]
    [SerializeField] private bool bannerAdEnabled = true;
    [SerializeField] private bool interstitialAdEnabled = true;
    [SerializeField] private bool rewardedAdEnabled = true;

    bool _firstInit = false;

    protected override void Awake()
    {
        base.Awake();

        // show banner every scene loaded
        SceneManager.sceneLoaded += (Scene s, LoadSceneMode lsm) => {  };
    }

    private void Start()
    {
      
    }

    private void OnDestroy()
    {
    }

    public void Destroy() => Destroy(gameObject);

    public bool IsRewardAdLoaded()
    {
    
            return false;
    }
    
}
