using System;
using System.Collections;
using System.Collections.Generic;
using MongoDB;
using MongoDB.Bson;
using UnityEditor.PackageManager;
using UnityEngine;

public class DataBaseController : MonoBehaviour
{
    private DataBase db;
    #region Singlenton
    public static DataBaseController instance;

    private bool isNew=false;

    public DataBase Db { get => db; set => db = value; }

    private void Awake ()
    {
        if ( instance == null )
        {
            instance = this;
            GameObject.DontDestroyOnLoad ( instance.gameObject );
            isNew = true;

        }

    }
    #endregion

    private void Start ()
    {
        GameEvent.instance.ClientChanged += UpdateClient;        
        db = new DataBase ();
        db.Init ();
       
    }

    public  void UpdateClient ()
    {
        if ( ClientController.kindClient.Equals(ClientController.Kind.company))
        {
            UpdateCompany ( ClientController.Client );
        }
        else if ( ClientController.kindClient.Equals ( ClientController.Kind.natural ) )
        {
            UpdateNaturalPerson ( ClientController.Client );
        }
    }

    public bool CheckLogin ( string id , string pass )
    {
        BranchOffice branchOffice = db.FindDocByIdNumber<BranchOffice>(db.NameCollecBrchOfc,id);
        
        if ( branchOffice is null )return false;
        if ( !branchOffice.Password.Equals ( pass ) )  return false;

        BranchOfficeController.SetBranchOffice ( branchOffice ); return true;
    }

    
    public bool IdExist ( string id )
    {
        Company company = db.FindDocByIdNumber<Company>(db.NameCollectCompany,id);

        if ( !(company is null ))
        {
            ClientController.Client = company ;
            ClientController.kindClient = ClientController.Kind.company;

            return true;
        }
        NaturalPerson naturalPerson = db.FindDocByIdNumber<NaturalPerson>(db.NameCollecNPeople,id);

        if ( !( naturalPerson is null ) )
        {
            ClientController.Client = naturalPerson;
            ClientController.kindClient = ClientController.Kind.natural;
            return true;
        }
        return false;
    }



    public void InsertNaturalClient (NaturalPerson doc) {
        db.InsertDoc<NaturalPerson> ( db.NameCollecNPeople , doc );
    }

    public void InsertCompany ( Company doc )
    {
        db.InsertDoc<Company> ( db.NameCollectCompany , doc );
    }



    public void UpdateCompany ( Company doc ) => db.UpdateDoc<Company> ( db.NameCollectCompany , doc._id , doc );
    public void UpdateNaturalPerson ( NaturalPerson doc ) => db.UpdateDoc<NaturalPerson>(db.NameCollecNPeople, doc._id, doc);

}
