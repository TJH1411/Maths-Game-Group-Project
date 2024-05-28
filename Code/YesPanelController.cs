using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class HelpPanelController : MonoBehaviour
{
    public GameObject YesPanel;
    private bool isYesPanelVisible = false;
    // Start is called before the first frame update
    void Start()
    {
        // Ensure the help panel starts hidden//
        YesPanel.SetActive(false);
    }

    public void ToggleYesPanel()
    {
        isYesPanelVisible = !isYesPanelVisible;
        YesPanel.SetActive(isYesPanelVisible);
    }
}
