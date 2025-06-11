using Assets.Scripts.Static;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class PlayerBasket : MonoBehaviour
{
    private int fruitCounts;

    public TMP_Text scoreTxt;
    public int numberOfFruits {  get; private set; }

    public int numberOfApples { get; private set; }
    public int numberOfBananas { get; private set; }

    private void Start()
    {
        fruitCounts = GameObject.FindGameObjectsWithTag("Fruit").Length;
    }
    public void FruitColleted()
    {
        numberOfFruits++;
    }

    public void AppleColleted()
    {
        numberOfApples++;
    }
    public void BananaColleted()
    {
        numberOfBananas++;
    }

    public void ScoreUpdate()
    {
        scoreTxt.text = ScoreManager.score.ToString();
    }
}
