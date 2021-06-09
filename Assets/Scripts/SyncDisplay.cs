using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SyncDisplay : MonoBehaviour
{
    public Transform MainCamera;
	public Transform display;
	public Transform otherdisplay;
	

    void Update()
    {
        Vector3 OffsetDisplays = MainCamera.position - otherdisplay.position;
		//transform.position = display.position + OffsetDisplays;
		
		float diffBetweenDisplayRotations = Quaternion.Angle(display.rotation, otherdisplay.rotation);
		
		Quaternion displayRotationalDiff = Quaternion.AngleAxis(diffBetweenDisplayRotations, Vector3.up);
		Vector3 newDir = displayRotationalDiff * MainCamera.forward;
		transform.rotation = Quaternion.LookRotation(newDir, Vector3.up);
    }
}
