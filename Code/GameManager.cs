using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    private AppleScript[] selectedApples = new AppleScript[2]; //Array to store the selected apples//
    private int targetTotal = 10;//Targettotal that user needs to achieve//
    public Text resultText;//That displays the result//

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }
    //Function to add selected apples to array//

    public void SelectApple(AppleScript apple)
    {
        for(int i =0 ; i< selectedApples.Length; i++)
        {
            if(selectedApples[i] == null)
            {
                selectedApples[i]= apple;
                apple.GetComponent<SpriteRenderer>().color = Color.yellow;
                break;
            }

        }
        if(selectedApples[1] !=null)
        {
            CheckTotal();
        }
    }

    private void CheckTotal()
    {
        int total = selectedApples[0].appleNumber + selectedApples[1].appleNumber;

        if(total==targetTotal)
        {
            resultText.text = "Correct! Total is " + total;
        }
        else
        {
            resultText.text = "Incorrect! Total is " + total;
        }
    }

    //Reset selected apples//
    private void ResetSelectedApples()
    {
        foreach ( AppleScript apple in selectedApples)
        {
            if(apple!=null)
            {
                apple.GetComponent<SpriteRenderer>().color = Color.white; // Reset color
            }
        }

        selectedApples = new AppleScript[2];
    }
    
}
