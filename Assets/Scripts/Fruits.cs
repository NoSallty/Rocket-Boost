using Assets.Scripts.Static;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Fruits : MonoBehaviour
{
    public GameObject uiText;
    public GameObject scoreTxt;
    [SerializeField] AudioClip apple;
    [SerializeField] AudioClip banana;
    private void OnTriggerEnter(Collider other)
    {
        PlayerBasket basket = other.GetComponent<PlayerBasket>();

        if (basket != null)
        {
            basket.FruitColleted();
            gameObject.SetActive(false);
        }
        if (gameObject.name == "Apple")
        {
            if (other.CompareTag("Player"))
            {
                PlaySound(apple);
                uiText.SetActive(true);
                ScoreManager.score += 1;
            }
            basket.AppleColleted();
            Invoke("Hide", 2f);
        }
        if (gameObject.name == "Banana")
        {
            if (other.CompareTag("Player"))
            {
                PlaySound(banana);
                uiText.SetActive(true);
                ScoreManager.score += 1;
            }
            basket.BananaColleted();

            Invoke("Hide", 2f);
        }
    }
    void Hide()
    {
        uiText.SetActive(false);
    }

    void PlaySound(AudioClip clip)
    {
        // Tạo AudioSource tạm thời
        GameObject tempAudio = new GameObject("TempAudio");
        AudioSource audioSource = tempAudio.AddComponent<AudioSource>();
        audioSource.clip = clip;
        audioSource.Play();

        // Xóa GameObject sau khi âm thanh kết thúc
        Destroy(tempAudio, clip.length);
    }
}
