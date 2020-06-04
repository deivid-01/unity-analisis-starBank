using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class BranchOfficeController 
{
   public static BranchOffice branchOffice;

    public static void CheckId ( string id ) {
        if ( id.Length == 0 || !DataBaseController.instance.IdExist(id))
        {
            GameEvent.instance.ClientDontFound ();
            return;
        }
        GameEvent.instance.ClientFound ();
    }

    public static void SetBranchOffice ( BranchOffice branchOff ) => branchOffice = branchOff;



}
