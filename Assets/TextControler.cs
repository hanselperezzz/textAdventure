using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class TextControler : MonoBehaviour {

	public Text text;

	enum States {cell, mirror, sheets_0, lock_0, cell_mirror, 
				sheets_1, lock_1, corridor_0, book, pushups,
				back_in_bed, floor, adventure, unknown,
				shut_eye
				};
	private States myState;

	// Use this for initialization
	void Start () {
		myState = States.cell;
	
	}
	
	// Update is called once per frame
	void Update () {
		print (myState);
		if 		(myState == States.cell)			{cell();}
		else if (myState == States.sheets_0)		{sheets_0();}
		else if (myState == States.sheets_1)		{sheets_1();}
		else if (myState == States.lock_0)			{lock_0();}
		else if (myState == States.lock_1)			{lock_1();}
		else if (myState == States.mirror)			{mirror();}
		else if (myState == States.cell_mirror)		{cell_mirror();}
		else if (myState == States.corridor_0)		{corridor_0();}
		else if (myState == States.book)			{book();}
		else if (myState == States.pushups)			{pushups();}
		else if (myState == States.back_in_bed)		{back_in_bed();}
		else if (myState == States.floor)			{floor();}
		else if (myState == States.adventure)		{adventure();}
		else if (myState == States.unknown)			{unknown();}
		else if (myState == States.shut_eye)		{shut_eye();}
	}

	void cell () {
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

	void sheets_0 () {
		text.text = "You feel tired. The sheets look awful, but you're so tired, it doesn't matter. " +
					"You lay down on the bed, close your eyes, and before you know it, you're dreaming " +
					"of cloud surfing with bears.\n\n" + 
					"Press G to get out of bed and move on with your life.";

		if (Input.GetKeyDown(KeyCode.G)) {
			myState = States.cell;
		}
	}

	void lock_0 () {
		text.text = "You take the lock in your hand and inspect it. It looks ancient. " +
					"You look through the rather large keyhole and can see the gears which ulock it. " +
					"If only you had something sharp with which to manipulate these gears.\n\n" +
					"Press G to go back and look around your room for something sharp.";
		if (Input.GetKeyDown(KeyCode.G)) {
			myState = States.cell;
		}
	}

	void mirror () {
		text.text = "You stare at yourself in the mirror for what seems like an hour. " +
					"In a flash of frustration and blind rage, you punch it, instantly shattering glass shards everyhere. " +
					"You stare at the mess. You get an unusually bright idea... you can use the glass to pick the lock!\n\n" +
					"Press R to return to your cell and go back to sleep. All this activity has made you tired. Press T to " +
					"take charge of your life for once and open this lock.";
		if (Input.GetKeyDown(KeyCode.R)) {
			myState = States.cell;
		} else if (Input.GetKeyDown(KeyCode.T)) {
			myState = States.cell_mirror;
		}
	}

	void cell_mirror () {
		text.text = "You cut your fingers a little, but after about five minutes of moving the lock's gears around with a glass shard, " +
					"you pop the lock open with an audibly satifying, CUH-LICK sound.\n\n" +
					"Press B to go back to bed. You seriously deserve a nap after all this action. " +
					"Press L to remove the lock and see what lies outside your cell door.";
		if (Input.GetKeyDown(KeyCode.R)) {
			myState = States.mirror;
		} else if (Input.GetKeyDown(KeyCode.L)) {
			myState = States.lock_1;
		} else if (Input.GetKeyDown(KeyCode.S)) {
			myState = States.sheets_1;
		}
	}

	void lock_1 () {
		text.text = "As quietly as you can, you softly open your rusty cell door. You walk out and look around. Your cell is at the end of " +
					"a long corridor. All the other inmates are asleep. No one is watching you. There is a door at the end of the corridor. It beckons you. " +
					"You've never been one to be influenced by anyone. Not even some dumb door. What do you do?\n\n" +
					"Press G and go to bed because this suspense is overwhelming, you can hardly keep your eyes open. " +
					"Press O to walk to the door and open it. You promise yourself you'll take a nap as soon as you escape the jail.";
		if (Input.GetKeyDown(KeyCode.G)) {
			myState = States.sheets_1;
		} else if (Input.GetKeyDown(KeyCode.O)) {
			myState = States.corridor_0;
		}
	}

	void sheets_1 () {
		text.text = "Sheets 1 state";
		if (Input.GetKeyDown(KeyCode.R)) {
			myState = States.cell_mirror;
		}
	}

	void corridor_0 () {
		text.text = "You open the door and you see your bedroom. You're unsure about what this means. You notice someone is sleeping in your bed. This " +
					"makes you a little mad. You walk up to this interloper and are about to shake them. When you get a good look at their face, you recognize it " +
					"immediately. It's you! It has been a weird couple of hours. You instinctively sit on the bed and lay down into yourself. " +
					"No more eating cheese before bed.\n\n" +
					"Press B to read a book, press P do pushups, press C to eat cheese before bed.";
		if (Input.GetKeyDown(KeyCode.B)) {
			myState = States.book;
		} else if (Input.GetKeyDown(KeyCode.P)) {
			myState = States.pushups;
		} else if (Input.GetKeyDown(KeyCode.C)) {
			myState = States.floor;
		}
	}

	void book () {
		text.text = "You can't sleep after that bizzare dream. However, it is the most fun you've had in a long time. You get out of bed and read a " +
					"little Borges to keep the momentum going.\n\n" +
					"You read until your eyes get heavy. Screw leaving the apartment today... you're going back to bed. Press B to return to your nice warm bed.";
		if (Input.GetKeyDown(KeyCode.B)) {
			myState = States.back_in_bed;
		}

	}

		void pushups () {
		text.text = "You can't sleep. Maybe you should do some pushups? Sure. You get out of bed and do twenty pushups. Great. Now you're wide awake.\n\n" + 
					"Press B to stop messing around and give this sleeping thing another shot.";
		if (Input.GetKeyDown(KeyCode.B)) {
			myState = States.back_in_bed;
		}
	}

		void back_in_bed () {
		text.text = "You return to bed and shut your eyes. You wake up after an hour or so. You sit up in bed and wonder about your next move.\n\n" +
					"Press B to read a book, press P do pushups, press C to eat some cheese.";
		if (Input.GetKeyDown(KeyCode.B)) {
			myState = States.book;
		} else if (Input.GetKeyDown(KeyCode.P)) {
			myState = States.pushups;
		} else if (Input.GetKeyDown(KeyCode.C)) {
			myState = States.floor;
		}
	}

		void floor () {
		text.text = "The cheese is too appealing. You go to your mini fridge and take a nip from your private stash.\n\n" + 
					"Press B to go back to bed and count sheep, press F to move forward with your next adventure.";
		if (Input.GetKeyDown(KeyCode.B)) {
			myState = States.back_in_bed;
		} else if (Input.GetKeyDown(KeyCode.F)) {
			myState = States.adventure;
		}
	}

		void adventure () {
		text.text = "Cheese acquires magical properties at bed time. You love cheese. You love magic, and you love bed time. Bring on the adventure.\n\n" +
					"Never mind, press B and go back to bed, or press U to move forward into the unknown.";
		if (Input.GetKeyDown(KeyCode.B)) {
			myState = States.back_in_bed;
		} else if (Input.GetKeyDown(KeyCode.U)) {
			myState = States.unknown;
		}
	}

			void unknown () {
		text.text = "The walls fall away and you are surrounded by black. The floor boards individually bend back and dissapear. The cieling fades away. " +
					"You are surrounded by an inky black.\n\n" + 
					"It's so dark. Might as well get some sleep. Press S to get some shut eye.";
		if (Input.GetKeyDown(KeyCode.S)) {
			myState = States.shut_eye;
		} 
	}

				void shut_eye () {
		text.text = "You have never experienced such complete silence before. This netherworld you find yourself in is perfect for catching up on some much " +
					"deserved rest.\n\n" + 
					"Congratulations. You have achieved the best sleep in the Universe. You can never tell anyone about it, but that's okay. No one would " + 
					"believe you, any way.\n\n" + "THE END";
 	}
}
