using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextureSetup : MonoBehaviour
{
    public Camera CameraRoom;
	public Material CameraRoomMat;
	public int depthCam;
	
    void Start()
    {
        if(CameraRoom.targetTexture != null)
		{
			CameraRoom.targetTexture.Release();
		}
		CameraRoom.targetTexture = new RenderTexture(Screen.width, Screen.height, depthCam);
		CameraRoomMat.mainTexture = CameraRoom.targetTexture;
    }
}
