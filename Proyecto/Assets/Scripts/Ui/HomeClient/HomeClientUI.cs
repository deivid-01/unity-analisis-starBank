using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class HomeClientUI : MonoBehaviour
{
    #region Propierties

    public NaturalPersonUI naturalPersonUI;
    public CompanyUI companyUI;
    public AccountsUI accountsUI;
 
    [Space]  
    public GameObject confirmationWindow;
    [Space]
    [Header ("Next Scenes")]
    public string nextScene;

    #endregion

    public void Start ()
    {
        naturalPersonUI.texts.SetActive ( false );
        companyUI.texts.SetActive ( false );
        ShowData ();
    }
    public void ShowData ()
    {
        if ( ClientController.kindClient.Equals ( ClientController.Kind.natural ) )
        {
            naturalPersonUI.ShowData ();
        }
        else if ( ClientController.kindClient.Equals ( ClientController.Kind.company ) )
        {
            companyUI.ShowData ();
        }
        accountsUI.ShowAccounts ( ClientController.Client );
    }
    public void OnPressAddSavingAccount () => accountsUI.AddSavingAccount ();
    public void OnPressAddCheckingAccount () => accountsUI.AddCheckingAccount ();

    public void DisableAccountButton () => accountsUI.ShowKindAccounts ();

    public void CloseWindow ( Text id ) {

        accountsUI.LoadAccount ( id.ToString () );
        GameEvent.instance.OpenNextScene(nextScene );
    }


    public void DeleteClient () 
    {
        ShowWindow ( confirmationWindow );
    }

    void ShowWindow ( GameObject window ) => window.SetActive ( true );
    void HideWindow ( GameObject window ) => window.SetActive ( false );


    public void DeleteClient ( bool answer )
    {

        if ( answer )
        {
            GameEvent.instance.DeleteClient ();
        }
        else
        {
            HideWindow ( confirmationWindow );
        }
    }

    public void Back () => GameEvent.instance.OpenNextScene ( "HomeOfficeBranch" );

}
