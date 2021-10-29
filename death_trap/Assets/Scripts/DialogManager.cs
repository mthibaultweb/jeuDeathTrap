/* Author : Raphaël Marczak - 2018/2020, for MIAMI Teaching (IUT Tarbes) and MMI Teaching (IUT Bordeaux Montaigne)
 * 
 * This work is licensed under the CC0 License. 
 * 
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

// This struct represents one dialog page
// (text on the current page, and its color)
[System.Serializable]
public struct DialogPage
{
    public string text;
    public Color color;
}

// This class is used to correctly display a full dialog
public class DialogManager : MonoBehaviour {

    public Text renderText;
    private List<DialogPage> dialogToDisplay;

    void Awake () {
dialogToDisplay = new List<DialogPage>();
    }

    // Sets the dialog to be displayed
    public void SetDialog(List<DialogPage> dialogToAdd)
    {
        dialogToDisplay = new List<DialogPage>(dialogToAdd);

        if (dialogToDisplay.Count > 0)
        {
            if (renderText != null)
            {
               renderText.text = "";
            }

            this.gameObject.SetActive(true);
        }
    }
	
	// Update is called once per frame
	void Update () {
        if (renderText == null)
        {
            this.gameObject.SetActive(false);
        }

        // Displays the current page
		if (dialogToDisplay.Count > 0)
        {
            renderText.text = dialogToDisplay[0].text;
        } else
        {
            // this.gameObject.SetActive(false);
            SceneManager.LoadScene(5);
        }

        // Removes the page when the player presses "n"
        if (Input.GetKeyDown(KeyCode.N))
        {
            dialogToDisplay.RemoveAt(0);
        }
	}

    public bool IsOnScreen()
    {
        return this.gameObject.activeSelf;
    }
}
