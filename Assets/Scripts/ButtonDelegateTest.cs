using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonDelegateTest : MonoBehaviour
{
	
	private delegate void DoSomething();

	private DoSomething something;

	private int pressCount = 0;

	// Attach the functions to the delegate
	private void Start() {
		something += increasePressCount;
		something += printButtonPressCount;
	}

	// This must be called by the Unity GUI Button OnClick Event
	public void pressButton(){
		something();
	}

	private void increasePressCount(){
		pressCount++;
	}
	
	private void printButtonPressCount(){
		Debug.Log("Press Count: " + pressCount.ToString());
	}
}
