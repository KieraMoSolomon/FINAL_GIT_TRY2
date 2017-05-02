using UnityEngine;
using System.Collections;

public class NumberOne : MonoBehaviour {
	string name = "Kiera Solomon, ";
	string time = "9:16.";
	string fullString;
	string hello = "Hello, ";

	// Use this for initialization
	void Start () {
		//NumberOne printOut = new NumberOne ();
		//string outPut = printOut.PrintHello();
		PrintHello();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	public void PrintHello (){
		fullString = hello + name + time;
		print (fullString);
	}
}
