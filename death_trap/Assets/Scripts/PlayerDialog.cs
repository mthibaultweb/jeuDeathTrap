using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDialog : MonoBehaviour
{
    // Start is called before the first frame update
    public DialogManager dialogDisplayer;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (dialogDisplayer.IsOnScreen())
        {
            return;
        }
    }
    private void OnTriggerEnter2D(Collider2D collision) {
        if (collision.tag == "InstantDialog")
        {
            Dialog instantDialog = collision.GetComponent<Dialog>();
            if (instantDialog != null)
            {
                dialogDisplayer.SetDialog(instantDialog.GetDialog());
            }
        }
    }
}
