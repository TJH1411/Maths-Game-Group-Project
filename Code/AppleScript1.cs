using TMPro;
using UnityEngine;

public class AppleScript1 : MonoBehaviour
{
    public int appleNumber; // Store the random number for this apple
    private GameManager1 gameManager1; // Reference to the GameManager
    public TextMeshPro num1; // Reference to the TextMeshPro component

    void Start()
    {
        gameManager1 = GameManager1.Instance;
        appleNumber = Random.Range(1, 8); // Assign a random number between 1 and 7 to the apple
        num1.text = appleNumber.ToString(); // Display the number on the apple
    }

    private void OnMouseDown()
    {
        gameManager1.SelectApple(this); // Notify GameManager when apple is selected
    }
}

