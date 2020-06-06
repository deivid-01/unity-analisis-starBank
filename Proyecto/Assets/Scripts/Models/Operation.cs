using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Operation 
{
	private string name;
	private int value;
	private DateTime dateTime;

	private BranchOffice branchOffice;

	public BranchOffice BranchOffice
	{
		get { return branchOffice; }
		set { branchOffice = value; }
	}

		
	public DateTime DateTime
	{
		get { return dateTime; }
		set { dateTime = value; }
	}

	public int Value
	{
		get { return value; }
		set { this.value = value; }
	}


	public string Name
	{
		get { return name; }
		set { name = value; }
	}


}
