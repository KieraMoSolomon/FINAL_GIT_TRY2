using UnityEngine;
using System.Collections;

public class NumberFive : MonoBehaviour {
	
	// Use this for initialization
	void Start () {
		int trainAMPH = 30;
		int trainBMPH = 60;
		int hoursLater = 4;
		SolveProblem (trainAMPH, trainBMPH, hoursLater);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	public void SolveProblem(int trainAMPH, int trainBMPH, int hoursLater){
		int milesApart = (trainAMPH + trainBMPH) * hoursLater;
		print (milesApart + " miles apart");
	}
}
