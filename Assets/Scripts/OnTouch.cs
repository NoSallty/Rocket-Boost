using Assets.Scripts.Static;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnTouch : MonoBehaviour
{
    public GameObject uiText;
    [SerializeField] AudioClip apple;
    private void OnTriggerEnter(Collider other)
    {
        PlayerBasket basket = other.GetComponent<PlayerBasket>();

        if (basket != null)
        {
            basket.FruitColleted();
            gameObject.SetActive(false);
        }
            if (other.CompareTag("Player"))
            {
                PlaySound(apple);
                uiText.SetActive(true);
                ScoreManager.score += 1;
                basket.ScoreUpdate();
            }
            Invoke("Hide", 2f);
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
