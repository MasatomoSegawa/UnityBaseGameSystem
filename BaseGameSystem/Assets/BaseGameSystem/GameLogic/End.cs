using UnityEngine;
using System.Collections;

public class End : GameLogic {

	public override void Init_GameLogic ()
	{
		base.Init_GameLogic ();
		Debug.Log ("おわりのはじまり!");

	}

	public override void Update_GameLogic ()
	{
		base.Update_GameLogic ();

	}

	public override void End_GameLogic ()
	{
		base.End_GameLogic ();
		Debug.Log ("End_End!!");

	}

}
