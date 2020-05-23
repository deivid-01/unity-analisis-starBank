using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BranchOfficeController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        LoadData ();
    }

    // Update is called once per frame
    void Update()
    {
    }

    void LoadData () { 
    
        //Communicate with database;
        //Show Data in UI
    }

    public static void CheckId ( string id ) {
        if ( id.Length == 0 )
        {
            GameEvent.instance.ClientDontFound ();
            return;
        }

        GameEvent.instance.ClientFound ();



    }

}
