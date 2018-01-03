using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController_Spring : MonoBehaviour {
    double[] cameraPoint = new double[] {0, 30, 32, 60, 62, 74, 76, 78, 80}; //Camera要轉換運鏡的時間點
    float updateSpeed = 0.01f; //轉換運鏡的速度
    double time; //時間
    Vector3 position; //Camera和Line的相對位置

    // Use this for initialization
    void Start () {
        InvokeRepeating("changeCamera", 0.0f, updateSpeed); //Camera運鏡
        InvokeRepeating("moveCamera", 0.0f, shareData_Spring.movingSpeed); //Camera跟隨Line
    }

    void changeCamera()
    {
        time = shareData_Spring.timer.ElapsedMilliseconds * 0.001;
        if (cameraPoint[0] <= time && time < cameraPoint[1])
        {
            position = new Vector3(0, 10f, -5); //Camera和Line的相對位置
            transform.eulerAngles = new Vector3(50, 0, 0); //Camera的旋轉角度
        }
        else if (cameraPoint[1] <= time && time < cameraPoint[2])
        {
            double timeConstant = (cameraPoint[2] - cameraPoint[1]) / updateSpeed;
            double positionConstant_x = ((-5)-0) / timeConstant;
            double positionConstant_y = (15-10) / timeConstant;
            double positionConstant_z = ((-10)-(-5)) / timeConstant;
            double rotationConstant = (45-0) / timeConstant;
            //位置變化
            position += new Vector3((float)positionConstant_x, (float)positionConstant_y, (float)positionConstant_z);
            //角度變化
            transform.eulerAngles += new Vector3(0, (float)rotationConstant, 0);
        }
        else if (cameraPoint[2] <= time && time < cameraPoint[3])
        {
            position = new Vector3(-5, 15, -10); //Camera和Line的相對位置
            transform.eulerAngles = new Vector3(50, 45, 0); //Camera的旋轉角度
        }
        else if (cameraPoint[3] <= time && time < cameraPoint[4])
        {
            double timeConstant = (cameraPoint[4] - cameraPoint[3]) / updateSpeed;
            double positionConstant_x = ((-5)-(-5)) / timeConstant;
            double positionConstant_y = (10-15) / timeConstant;
            double positionConstant_z = (0-(-10)) / timeConstant;
            double rotationConstant = (90-45) / timeConstant;
            //位置變化
            position += new Vector3((float)positionConstant_x, (float)positionConstant_y, (float)positionConstant_z);
            //角度變化
            transform.eulerAngles += new Vector3(0, (float)rotationConstant, 0);
        }
        else if(cameraPoint[4] <= time && time < cameraPoint[5])
        {
            position = new Vector3(-5, 10f, 0); //Camera和Line的相對位置
            transform.eulerAngles = new Vector3(50, 90, 0); //Camera的旋轉角度
        }
        else if (cameraPoint[5] <= time && time < cameraPoint[6])
        {
            double timeConstant = (cameraPoint[6] - cameraPoint[5]) / updateSpeed;
            double positionConstant_x = ((-7.5) - (-5)) / timeConstant;
            double positionConstant_y = (2.5 - 10) / timeConstant;
            double rotationConstant = (10 - 50) / timeConstant;
            //位置變化
            position += new Vector3((float)positionConstant_x, (float)positionConstant_y, 0);
            //角度變化
            transform.eulerAngles += new Vector3((float)rotationConstant, 0, 0);
        }
        else if(cameraPoint[6] <= time && time < cameraPoint[7])
        {
            position = new Vector3(-7.5f, 2.5f, 0); //Camera和Line的相對位置
            transform.eulerAngles = new Vector3(10, 90, 0); //Camera的旋轉角度
        }
        else if (cameraPoint[7] <= time && time < cameraPoint[8])
        {
            double timeConstant = (cameraPoint[8] - cameraPoint[7]) / updateSpeed;
            double positionConstant_x = (0 - (-7.5)) / timeConstant;
            double rotationConstant = ((-90) - 10) / timeConstant;
            //位置變化
            position += new Vector3((float)positionConstant_x, 0, 0);
            //角度變化
            transform.eulerAngles += new Vector3((float)rotationConstant, 0, 0);
        }
        else
        {
            position = new Vector3(0, 2.5f, 0); //Camera和Line的相對位置
            transform.eulerAngles = new Vector3(-90, 90, 0); //Camera的旋轉角度
        }
    }

    void moveCamera()
    {
        transform.localPosition = shareData_Spring.trackCubePosition + position;
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
