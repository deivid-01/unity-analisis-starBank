using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MongoDB.Bson;

public class NaturalPerson:Client
    
{

    public NaturalPerson ( string iD , string contactNum , string fullName , string occupation , string address ) :
        base ( iD , contactNum , fullName , occupation , address )
    {
     
    }

     
 }


