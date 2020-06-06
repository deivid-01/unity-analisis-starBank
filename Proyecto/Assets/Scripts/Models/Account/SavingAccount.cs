using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MongoDB.Bson;
public class SavingAccount:Account 
{
    [Range(0,1)]
	public const float monthlyInterestPercentage=0.1f;

	public SavingAccount ( BranchOffice openingBranch )
		: base ( openingBranch ) { 
		
	}


}
	