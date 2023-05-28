using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using TMPro;

public class Game : MonoBehaviour
{
    public TextMeshProUGUI ui;

    public void Increment()
    {
        GameManager.points += GameManager.multiplier;
        Debug.Log("+1");
    }

    public void BuyBoost(int num) 
    {   
        //button +1
        if (num == 1 && GameManager.points >= 25) 
        { 
            GameManager.multiplier ++;
            GameManager.points -= 25;
            Debug.Log("-25");
        }
        //button +10
        if (num == 2 && GameManager.points >= 125)
        {
            GameManager.multiplier += 10;
            GameManager.points -= 125;
            Debug.Log("-125");
        }

        //button +100
        if (num == 3 && GameManager.points >= 1500)
        {
            GameManager.multiplier += 100;
            GameManager.points -= 1500;
            Debug.Log("-1500");
        }
    }

    public void Update()
    {
        ui.text = "Point: " + GameManager.points;
    }
}
