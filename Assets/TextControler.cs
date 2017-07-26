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
		else if (myState == States.sheets_0)		{state_sheets_0();}
		else if (myState == States.sheets_1)		{state_sheets_1();}
		else if (myState == States.lock_0)			{state_lock_0();}
		else if (myState == States.lock_1)			{state_lock_1();}
		else if (myState == States.mirror)			{state_mirror();}
		else if (myState == States.cell_mirror)		{state_cell_mirror();}
		else if (myState == States.freedom)			{state_freedom();}
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
		} else if (Input.GetKeyDown(KeyCode.L)) {
			myState = States.lock_0;
		} else if (Input.GetKeyDown(KeyCode.M)) {
			myState = States.mirror;
		}
	}

	void state_sheets_0 () {
		text.text = "You feel tired. The sheets look awful, but you're so tired, it doesn't matter. " +
					"You lay down on the bed, close your eyes, and before you know it, you're dreaming " +
					"of cloud surfing with bears.\n\n" + 
					"Press G to get out of bed and move on with your life.";

		if (Input.GetKeyDown(KeyCode.G)) {
			myState = States.cell;
		}
	}

	void state_lock_0 () {
		text.text = "Lock!";
		if (Input.GetKeyDown(KeyCode.R)) {
			myState = States.cell;
		}
	}

	void state_mirror () {
		text.text = "You stare at yourself in the mirror for what seems like an hour. " +
		"In a flash of frustration and blind rage, you punch it, instantly shattering glass shards everyhere. " +
		"You stare at the mess. You get an idea.";
		if (Input.GetKeyDown(KeyCode.R)) {
			myState = States.cell;
		} else if (Input.GetKeyDown(KeyCode.T)) {
			myState = States.cell_mirror;
		}
	}

	void state_cell_mirror () {
		text.text = "Cell mirror state";
		if (Input.GetKeyDown(KeyCode.R)) {
			myState = States.mirror;
		} else if (Input.GetKeyDown(KeyCode.L)) {
			myState = States.lock_1;
		} else if (Input.GetKeyDown(KeyCode.S)) {
			myState = States.sheets_1;
		}
	}

	void state_lock_1 () {
		text.text = "Lock 1 state";
		if (Input.GetKeyDown(KeyCode.R)) {
			myState = States.cell_mirror;
		} else if (Input.GetKeyDown(KeyCode.O)) {
			myState = States.freedom;
		}
	}

		void state_sheets_1 () {
		text.text = "Sheets 1 state";
		if (Input.GetKeyDown(KeyCode.R)) {
			myState = States.cell_mirror;
		}
	}

			void state_freedom () {
		text.text = "Freedom!";
		if (Input.GetKeyDown(KeyCode.R)) {
			myState = States.cell_mirror;
		}
	}
}
