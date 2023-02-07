using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectibleCount : MonoBehaviour
{
    private AudioSource coinsfx;
    TMPro.TMP_Text text;
    int count;
    // Start is called before the first frame update
    void Awake()
    {
        coinsfx = GetComponent<AudioSource>();
        text = GetComponent<TMPro.TMP_Text>();
    }

    void Start() => UpdateCount();

    void OnEnable() => Coin.OnCollected += OnCollectibleCollected;
    void OnDisable() => Coin.OnCollected -= OnCollectibleCollected;

    void OnCollectibleCollected()
    {
        count++;
        UpdateCount();
    }

    void UpdateCount()
    {
        coinsfx.Play();
        text.text = $"Coins: {count} / {Coin.total}";
    }
}
