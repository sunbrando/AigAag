using UnityEngine;
using System.Collections;

public class CameraCtrl : MonoBehaviour {

    void Reset()
    {
        ResetCamera();
    }

	void Awake () {
        CameraStartView();
	}
	
    //初始化相机的位置
    void ResetCamera()
    {
        transform.position = new Vector3(0, 21, -37);
        transform.localEulerAngles = new Vector3(15, 0, 0);
    }


    //游戏开始时摄像机视角的角度
	void CameraStartView()
    {
        float sinValue = Convention.VIEW_SINVALUE;

        transform.position = new Vector3(transform.position.z * sinValue, transform.position.y, transform.position.z * sinValue);
        transform.localEulerAngles = new Vector3(transform.localEulerAngles.x, 45, transform.localEulerAngles.z);
    }

}
