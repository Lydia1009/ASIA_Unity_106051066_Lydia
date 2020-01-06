using UnityEngine;
using System.Collections;

public class CameriaTrack : MonoBehaviour
{
    private Vector3 offset = new Vector3(0, 5, 4);//相機相對於玩家的位置
    private Transform target;
    private Vector3 pos;

    public float speed = 2;

    // Use this for initialization
    void Start()
    {
        target = GameObject.FindGameObjectWithTag("Player").transform;

    }

    // Update is called once per frame
    void Update()
    {
        pos = target.position + offset;
        this.transform.position = Vector3.Lerp(this.transform.position, pos, speed * Time.deltaTime);//調整camera與玩家距離
        Quaternion angel = Quaternion.LookRotation(target.position - this.transform.position);//旋轉角度
        this.transform.rotation = Quaternion.Slerp(this.transform.rotation, angel, speed * Time.deltaTime);

    }
}
