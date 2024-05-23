using TMPro;
using UnityEngine;

public class AppleScript : MonoBehaviour
{
    public int appleNumber; // Store the random number for this apple
    private GameManager gameManager; // Reference to the GameManager
    public TextMeshPro num; // Reference to the TextMeshPro component

    void Start()
    {
        gameManager = GameManager.Instance;
        appleNumber = Random.Range(1, 10); // Assign a random number between 1 and 9 to the apple
        num.text = appleNumber.ToString(); // Display the number on the apple
    }

    private void OnMouseDown()
    {
        gameManager.SelectApple(this); // Notify GameManager when apple is selected
    }
}

