using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

public class NumberThree : MonoBehaviour {
	public List<int> averages = new List<int>();
	// Use this for initialization
	void Start () {
		averages.Add (2);
		averages.Add (2);
		AverageOfInt ();
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	public void AverageOfInt(){
		int sumAvg = averages.Sum();
		int dividedAvg = (sumAvg / averages.Count);
		print (dividedAvg);
		}
	}
