using UnityEngine;
using System.Collections;
using System;
public class clock : MonoBehaviour {

	// Use this for initialization
	public GameObject hourHand;
	public GameObject minuteHand;
	public GameObject secondHand;



	
	// Update is called once per frame
	void Update () 
	{
		//fetch tge current time.
		DateTime time = DateTime.Now;
		//set the second hand root.
		int seconds = time.Second;

		//map seconds (0,60) to rotate (0,360)
		float seconds_normalized = seconds / 60f;
		float seconds_degrees = seconds_normalized * 360f;
		float clockwise_seconds = 360f - seconds_degrees;
	//		{ x, y, z }
		Vector3 secondRotation = new Vector3(0f, 0f, clockwise_seconds);
		Quaternion secondsRotationQuat = Quaternion.Euler (secondRotation);
		secondHand.transform.rotation = secondsRotationQuat;

		int hours = time.Hour;

		float hours_normalized = hours / 24f;
		float hours_degrees = hours_normalized * 360f;
		float clockwise_hours = 360f - hours_degrees;
		Vector3 hoursRotation = new Vector3(0f, 0f, clockwise_hours);
		Quaternion hoursRotationQuat = Quaternion.Euler (hoursRotation);
		hourHand.transform.rotation = hoursRotationQuat;

		int minutes = time.Minute;

		float minutes_normalized = minutes / 60f;
		float minutes_degrees = minutes_normalized * 60f;
		float clockwise_minutes = 60f - minutes_degrees;
		Vector3 minutesRotation = new Vector3(0f, 0f, clockwise_minutes);
		Quaternion minutesRotationQuat = Quaternion.Euler (minutesRotation);
		minuteHand.transform.rotation = minutesRotationQuat;


}
}		