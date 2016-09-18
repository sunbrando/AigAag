using UnityEngine;
using System.Collections;

public class PlatformCtrl : MonoBehaviour {

    public GameObject Platform;

	void Reset () 
    {
        Platform = GameObject.Find("Platform");
        RestPos();
	}
	
    //初始化位置
	public void RestPos()
    {
        float posY = -(Platform.transform.localScale.y / 2 + Convention.SPHERE_SIZE / 2);
        Platform.transform.position = new Vector3(0, posY, 0);
    }
}
