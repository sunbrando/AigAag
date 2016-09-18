using UnityEngine;
using System.Collections;

/// <summary>
/// 相机跟随目标
/// </summary>
public class CameraFollow : MonoBehaviour {

    //目标
    public GameObject followTarget;

    //摄像机默认位置
    private Vector3 mCamFirstPos;
    //目标最后一次位置
    private Vector3 mLastTagPosition;
    //目标开始时的位置
    private Vector3 mFirstTagPosition;

	// Use this for initialization
	void Start () {
        mCamFirstPos = transform.position;
        mLastTagPosition = followTarget.transform.position;
        mFirstTagPosition = followTarget.transform.position;
	}

    void LateUpdate()
    {
        if (Mathf.Abs(mFirstTagPosition.y - followTarget.transform.position.y) < 1)
        {
            transform.position = UpdateCamPosition(mCamFirstPos, followTarget.transform.position, mLastTagPosition, Time.deltaTime);
        }
        mLastTagPosition = followTarget.transform.position;

        //CameraMove();
    }

    //更新相机的位置
    Vector3 UpdateCamPosition(Vector3 camFirstPos, Vector3 tagNowPos, Vector3 tagLastPos, float deltaTime)
    {
        //float deltaPosX = Mathf.Lerp(0, tagNowPos.x - tagLastPos.x, deltaTime);
        //float deltaPosZ = Mathf.Lerp(0, tagNowPos.z - tagLastPos.z, deltaTime);
        //Vector3 position = new Vector3(camFirstPos.x + tagLastPos.x + deltaPosX, camFirstPos.y + tagLastPos.y, camFirstPos.z + tagLastPos.z + deltaPosZ);

        Vector3 position = camFirstPos + tagNowPos ;

        return position;
    }

}
