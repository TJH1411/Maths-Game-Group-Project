
using TMPro;
using UnityEngine;
using UnityEngine.UI;


public class AppleScript : MonoBehaviour
{
    public TextMeshPro num;

    void Start()
    {
        num = GetComponent<TextMeshPro>();
        if (num != null )
        {
            int number = Random.Range(1, 10);
            num.text = number.ToString();
        }
        else
        {
            Debug.LogError("Not Working");
        }
    }
}
