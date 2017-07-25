using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class TextControler : MonoBehaviour {

	public Text text;

	enum States {cell, mirror, sheets_0, lock_0, cell_mirror, sheets_1, lock_1, freedom};
	private States myState;

	// Use this for initialization
	void Start () {
		myState = States.cell;
	
	}
	
	// Update is called once per frame
	void Update () {
		print (myState);
		if (myState == States.cell)					{state_cell();}
		// else if (myState == States.sheets_0)		{state_sheets_0();}
//		else if (myState == States.sheets_1)		{state_sheets_1();}
//		else if (myState == States.lock_0)			{state_lock_0();}
//		else if (myState == States.lock_1)			{state_lock_1();}
//		else if (myState == States.mirror)			{state_mirror();}
//		else if (myState == States.cell_mirror)		{state_cell_mirror();}
//		else if (myState == States.freedom)			{state_freedom();}
	}

	void state_cell () {
		text.text = "Because of your life choices, you find yourself in a prison cell. " + 
					"You are not the best at making good decisions. Instead of spending " +
					"the next week behind bars, you commit yourself to escaping. There are " + 
					"stiff looking sheets on the cell bed and a mirror on the wall. The " + 
					"bars are locked from the outside.\n\n" + 
					"Press S to view Sheets, M to view Mirror and L to view Lock.";

		if (Input.GetKeyDown(KeyCode.S)) {
			myState = States.sheets_0;
		}
	}

	// void state_sheets_0 () {
	// 	text.text = "You feel tired. The sheets look awful, but you're so tired, it doesn't matter. " +;
	// 				"You lay down on the bed, close your eyes, and before you know it, you're dreaming " +
	// 				"of cloud surfing.";

	// 	if (Input.GetKeyDown(KeyCode.R)) {
	// 		myState = States.cell;
	// 	}
	// }

//	void state_lock_0 () {
//		text.text = "Lock!";
//		if (Input.GetKeyDown(KeyCode.L)) {
//			myState = States.cell;
//		}
//	}
//
//	void state_lock_1 () {
//		text.text = "Lock one!";
//		if (Input.GetKeyDown(KeyCode.R)) {
//			myState = States.cell;
//		}
//	}
}
