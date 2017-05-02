using UnityEngine;
using System.Collections;

public class NumberTwo : MonoBehaviour {
	// Use this for initialization
	void Start () {
		int numberOne = 10;
		int numberTwo = 2;
		Results (numberOne, numberTwo);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	public void Results(int numOne, int numTwo){
		int addIt = numOne + numTwo;
		int subIt = numOne - numTwo;
		int multIt = numOne * numTwo;
		int divideIt = numOne / numTwo;
		print (addIt);
		print (subIt);
		print (multIt);
		print (divideIt);
	}
}
