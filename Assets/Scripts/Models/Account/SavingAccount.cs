using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SavingAccount:Account 
{
    [Range(0,1)]
	private float monthlyInterestPercentage;

	public float MonthlyInterestPercentage
	{
		get { return monthlyInterestPercentage; }
		set { monthlyInterestPercentage = value; }
	}

}
	