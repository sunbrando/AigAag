using UnityEngine;
using System.Collections;

/// <summary>
/// 相机跟随目标
/// </summary>
public class CameraFollow : MonoBehaviour {

    public GameObject followTarget;

    private Vector3 mCamFirstPos;
    private Vector3 mLastPosition;

	// Use this for initialization
	void Start () {
        mCamFirstPos = transform.position;
        mLastPosition = followTarget.transform.position;
	}
	
	// Update is called once per frame
	void Update () {
	    
	}

    void LateUpdate()
    {
        //float deltaPosZ = followTarget.transform.position.z - mLastPosition.z;
        //mLastPosition = followTarget.transform.position;
        //transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z + deltaPosZ);
        if (mLastPosition.y == followTarget.transform.position.y)
        {
            transform.position = new Vector3(mCamFirstPos.x + followTarget.transform.position.x, mCamFirstPos.y + followTarget.transform.position.y, mCamFirstPos.z + followTarget.transform.position.z);
        }

    }
}
