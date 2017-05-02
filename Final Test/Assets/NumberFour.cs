using UnityEngine;
using System.Collections;

public class NumberFour : MonoBehaviour {
	public const int inchesInFoot = 12;
	public int feet = 0;
	public int leftOverInches = 0;
	// Use this for initialization
	void Start () {
		int inches = 138;
		Conversion (inches);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	public void Conversion(int inches){
		if (inches >= inchesInFoot){
			feet = inches/inchesInFoot;
			leftOverInches = inches % inchesInFoot;
		}
		print (feet + "feet ");
		print (leftOverInches + "inches");
	}
}
