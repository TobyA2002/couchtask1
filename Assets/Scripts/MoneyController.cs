using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class MoneyController : MonoBehaviour
{
    private int currentMoney = 0;
    public Text scoreText;
   
    void Start()
    {
        scoreText.text = currentMoney.ToString();
    }

    public void IncrementScore()
    {
        currentMoney += 1;
        scoreText.text = currentMoney.ToString();
    }

    public void IncrementScoreBoss()
    {
        currentMoney += 100;
        scoreText.text = currentMoney.ToString();
    }



}
