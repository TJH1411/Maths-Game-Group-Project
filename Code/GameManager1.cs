using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameManager1 : MonoBehaviour
{
    public static GameManager1 Instance;

    private AppleScript1[] selectedApples = new AppleScript1[2]; //Array to store the selected apples//
    private int targetTotal = 5;//Targettotal that user needs to achieve//
    public TextMeshProUGUI resultText1;//That displays the result//

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

    public void SelectApple(AppleScript1 apple)
    {
        for(int i =0 ; i< selectedApples.Length; i++)
        {
            if(selectedApples[i] == null)
            {
                selectedApples[i]= apple;
                apple.GetComponent<MeshRenderer>().material.color = Color.yellow;
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
        int total = selectedApples[0].appleNumber - selectedApples[1].appleNumber;

        if(total==targetTotal)
        {
            resultText1.text = "Correct! Total is " + total;
        }
        else
        {
            resultText1.text = "Incorrect! Total is " + total;
        }
    }

    //Reset selected apples//
    private void ResetSelectedApples()
    {
        foreach ( AppleScript1 apple in selectedApples)
        {
            if(apple!=null)
            {
                apple.GetComponent<MeshRenderer>().material.color = Color.white; // Reset color to white
            }
        }

        selectedApples = new AppleScript1[2];
    }
    
}
