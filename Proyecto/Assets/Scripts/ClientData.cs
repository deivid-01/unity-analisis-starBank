using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
[Serializable]
public struct NaturalPersonData
{
    public string fullName;
    public  string id;
    public  string occupation;
    public string address;
    public  string contactNumber;

    public NaturalPersonData ( string fullName , string id , string occupation , string address , string contactNumber )
    {
        this.fullName = fullName;
        this.id = id;
        this.occupation = occupation;
        this.address = address;
        this.contactNumber = contactNumber;
    }

    public static bool VerifyData ( NaturalPersonData data ) =>
            ( data.id.Length != 10 ||
            data.contactNumber.Length != 10 ||
            data.fullName.Length == 0 ||
            data.occupation.Length == 0 ||
            data.address.Length == 0 ) ? false : true;
    
}


[Serializable]
public struct CompanyData
{
    public string fullName;
    public  string id;
    public  string occupation;
    public string address;
    public  string contactNumber;

    public  string NIT;
    public  string companyName;
    public  string commercialSector;

    public CompanyData ( string fullName , string id , string occupation , string address , string contactNumber , string nIT , string companyName , string commercialSector )
    {
        this.fullName = fullName;
        this.id = id;
        this.occupation = occupation;
        this.address = address;
        this.contactNumber = contactNumber;
        NIT = nIT;
        this.companyName = companyName;
        this.commercialSector = commercialSector;
    }

    public static bool VerifyData ( CompanyData data ) =>
            ( data.id.Length != 10 ||
             data.contactNumber.Length != 10 ||
             data.fullName.Length == 0 ||
             data.occupation.Length == 0 ||
             data.address.Length == 0 || 
             data.NIT.Length == 0 || 
             data.companyName.Length == 0 || 
             data.commercialSector.Length == 0 ) ? false : true;
}
