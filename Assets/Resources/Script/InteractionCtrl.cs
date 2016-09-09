using UnityEngine;
using System.Collections;

/// <summary>
/// 相互控制
/// </summary>
public class InteractionCtrl : MonoBehaviour {

    //点击屏幕事件
    public delegate void MouseDown();
    public static event MouseDown MouseDownEven;


	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButtonDown(0))
        {
            MouseDownEven();
        }
	}
}
