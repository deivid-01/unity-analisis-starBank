using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AccountController : MonoBehaviour
{
    private static  dynamic account;

    public static  dynamic Account
    {
        get { return account; }
        set { account = value; }
    }

    public static Kind kind;

    public enum Kind
    {
        saving,
        checking
    }

    void Start ()
    {

    }

    // Update is called once per frame
    void Update ()
    {

    }

    public static void ActiveInactiveAccount ()
    {
        //Disable or active account
        Debug.Log ( "Account has been active o disable" );
    }

    public static void DeleteAccount ()
    {
        //Delete account
        Debug.Log ( "Account has been deleted" );
    }

    public static void WithDraw ( string amount )
    {
        Debug.Log ( "Amount withdrawn: " + amount );

    }

    public static void Allocate ( string amount )
    {
        Debug.Log ( "Amount allocated: " + amount );

    }

    public static void CreateAccountOf ( AccountController.Kind kind )
    {
        if ( kind.Equals ( AccountController.Kind.saving ) )
        {
            ClientController.Client.SavingAccounts.Add ( new SavingAccount ( BranchOfficeController.branchOffice ) );
        }
        else if ( kind.Equals ( AccountController.Kind.checking ) )
        {
            ClientController.Client.CheckingAccounts.Add ( new CheckingAccount ( BranchOfficeController.branchOffice ) );
        }

        GameEvent.instance.UpdateClient ();
      
    }

    public static void SetAccount ( string id ) {

        //Search account with id and set to account

        foreach ( SavingAccount savingAccount in ClientController.Client.SavingAccounts )
        {
            if ( savingAccount._id.ToString ().Equals ( id ) )
            {
                Account = savingAccount;
                AccountController.kind = AccountController.Kind.saving;
                break;
            }
        }

        foreach ( CheckingAccount savingAccount in ClientController.Client.CheckingAccounts )
        {
            if ( savingAccount._id.ToString ().Equals ( id ) )
            {
                Account = savingAccount;
                AccountController.kind = AccountController.Kind.checking;
                break;
            }
        }
    }

}
