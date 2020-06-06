using MongoDB.Bson;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Company : Client
{
  
    private string NIT;
    private string companyName;
    private string commercialSector;

    public Company ( string iD , string contactNum , string fullName , string occupation , string address ,
                          string NIT,string companyName,string commercialSector) :
        base (  iD , contactNum , fullName , occupation , address  )
    {
        this.NIT = NIT;
        this.companyName = companyName;
        this.commercialSector = commercialSector;
    }

    public string CommercialSector
    {
        get { return commercialSector; }
        set { commercialSector = value; }
    }


    public string CompanyName
    {
        get { return companyName; }
        set { companyName = value; }
    }


    public string nIT
    {
        get { return NIT; }
        set { NIT = value; }
    }







}
