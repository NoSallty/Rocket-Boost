using Assets.Scripts.Static;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Star : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject[] stars;
    public UnityEngine.SceneManagement.Scene scene;
    string lvlName;
    float sc;

    void Start()
    {
        lvlName = SceneManager.GetActiveScene().name;
    }
    void Update()
    {
        StarRating();
    }

    public void StarRating()
    {
            switch (ScoreManager.score)
            {
                case 0:
                    stars[0].SetActive(true);
                    break;
                case 1:
                    stars[0].SetActive(true);
                    stars[1].SetActive(true);
                    break;
                case 2:
                    stars[0].SetActive(true);
                    stars[1].SetActive(true);
                    stars[2].SetActive(true);
                    break;
                default:
                    break;
        }
       
    }
}
