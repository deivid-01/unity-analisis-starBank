using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Account 
{

	public ObjectId _id;
	private int balance=0;
	private bool active=false;
	private BranchOffice openingBranch;
	private List<Operation>operations =  new List<Operation>();

	protected Account (  BranchOffice openingBranch )
	{
		_id = ObjectId.GenerateNewId();
		this.openingBranch = openingBranch;
		GameEvent.instance.UpdateClient ();
	}

	public BranchOffice OpeningBranch
	{
		get { return openingBranch; }
		set { openingBranch = value; }
	}


	public bool Active
	{
		get { return active; }
		set { active = value; }
	}


	public int Balance
	{
		get { return balance; }
		set { balance = value; }
	}

	public List<Operation> Operations { get => operations; set => operations = value; }
}
