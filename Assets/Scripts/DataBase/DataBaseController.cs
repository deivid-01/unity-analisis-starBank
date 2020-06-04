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
        db = new DataBase ();
        db.Init ();

        Operation operation = new Operation
        {
            Name ="First Operation"
        };
        BranchOffice branchOffice = new BranchOffice
        {
            iD="branch-bog",
            City = "Bogota",
            Password = "12345",
            Address = "Calle 43-12"
        };
        SavingAccount account = new SavingAccount
        {
            _id = ObjectId.GenerateNewId(),
            Balance=500,
            Active=true,
            OpeningBranch=branchOffice,
            Operations={ 
                operation
            }

        };

        CheckingAccount account2 = new CheckingAccount
        {
            _id = ObjectId.GenerateNewId(),
            Balance=80000,
            Active=true,
            OpeningBranch=branchOffice,
            Operations={
                operation
            }

        };

        SavingAccount account3 = new SavingAccount
        {
            _id = ObjectId.GenerateNewId(),
            Balance=33323,
            Active=true,
            OpeningBranch=branchOffice,
            Operations={
                operation
            }

        };



        NaturalPerson client = new NaturalPerson
        {
            iD="987",
            ContactNum=2223,
            FullName="Deivid Torres",
            Occupation="Student",
            Address = "Calle 123-12f-2",
            SavingAccounts={
                account,
                account3
            },
            CheckingAccounts={ 
               account2
            }
            


        };

        Company company = new Company
        {
            iD="12312312",
            ContactNum=123423423,
            FullName="Alfonsito",
            Occupation="Vagabundo",
            nIT="44343",
            CompanyName ="BolitaRun",
            CommercialSector="Ventas",
            Address="Calle 34 666"
        };

        db.InsertDoc<NaturalPerson> ( db.NameCollecNPeople , client );

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
        NaturalPerson naturalPerson = db.FindDocByIdNumber<NaturalPerson>(db.NameCollectCompany,id);

        if ( IsNull<Company>(company)  || IsNull<NaturalPerson> ( naturalPerson ) )
        {
            return true;
        }
        return false;
    }

    public bool IsNull<T>( T obj ) {
        if (! (obj == null )){ 
            ClientController.SetClient ( obj );
            return true;
        }
        return false;
    }


}
