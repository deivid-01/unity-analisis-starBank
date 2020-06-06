using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HomeAccountUI : MonoBehaviour
{
    public AccountUI accountUI;
    
    public GameObject confirmationPanel;
    public GameObject withDrawWindow;
    public GameObject allocateWindow;
    private string ownerPanel;

    public void ShowWindow ( GameObject window )
    {
        window.SetActive ( true );
    }
    public void HideWindow ( GameObject window )
    {
        window.SetActive ( false );
    }

    public void ActiveInactiveAccount ()
    {
        ShowWindow ( confirmationPanel );
        ownerPanel = "activeInactive";
    }

    public void GetAnswer ( bool answer )
    {
        if ( answer )
        {
            if ( ownerPanel.Equals ( "activeInactive" ) )
            {
                AccountController.ActiveInactiveAccount ();
            }
            else if ( ownerPanel.Equals ( "delete" ) )
            {
                AccountController.DeleteAccount ();
            }
        }
        HideWindow ( confirmationPanel );
    }

    public void DeleteAccount ()
    {
        ShowWindow ( confirmationPanel );
        ownerPanel = "delete";

    }

    public void WithDraw (InputField amount) {
        AccountController.WithDraw ( amount.text );
        HideWindow (withDrawWindow);
    }

    public void Allocate ( InputField amount )
    {
        AccountController.Allocate ( amount.text );
        HideWindow ( allocateWindow );

    }

    public void Back ()
    {
        GameEvent.instance.OpenNextScene ( "HomeClient" );
    }
}
