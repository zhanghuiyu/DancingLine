using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController_Winter : MonoBehaviour {
    double[] cameraPoint = new double[] { 0, 13, 15, 25, 27, 41, 43, 59, 61, 75, 77, 89, 91, 96, 100, 102, 104, 106, 108 }; //Camera要轉換運鏡的時間點
    float updateSpeed = 0.01f; //轉換運鏡的速度
    double time; //時間
    Vector3 position; //Camera和Line的相對位置

    // Use this for initialization
    void Start()
    {
        InvokeRepeating("changeCamera", 0.0f, updateSpeed); //Camera運鏡
        InvokeRepeating("moveCamera", 0.0f, shareData_Winter.movingSpeed); //Camera跟隨Line
    }

    void changeCamera()
    {
        time = shareData_Winter.timer.ElapsedMilliseconds * 0.001;
        if (cameraPoint[0] <= time && time < cameraPoint[1])
        {
            position = new Vector3(-5f, 15f, -5f); //Camera和Line的相對位置
            transform.eulerAngles = new Vector3(50, 45, 0); //Camera的旋轉角度
        }
        else if (cameraPoint[1] <= time && time < cameraPoint[2])
        {
            double timeConstant = (cameraPoint[2] - cameraPoint[1]) / updateSpeed;
            double positionConstant_x = (0-(-5)) / timeConstant;
            double positionConstant_z = ((-7.5) - (-5)) / timeConstant;
            double rotationConstant = (0-45) / timeConstant;
            //位置變化
            position += new Vector3((float)positionConstant_x, 0, (float)positionConstant_z);
            //角度變化
            transform.eulerAngles += new Vector3(0, (float)rotationConstant, 0);
        }
        else if (cameraPoint[2] <= time && time < cameraPoint[3])
        {
            position = new Vector3(0, 15f, -7.5f); //Camera和Line的相對位置
            transform.eulerAngles = new Vector3(50, 0, 0); //Camera的旋轉角度
        }
        else if (cameraPoint[3] <= time && time < cameraPoint[4])
        {
            double timeConstant = (cameraPoint[4] - cameraPoint[3]) / updateSpeed;
            double positionConstant_x = ((-5)-0) / timeConstant;
            double positionConstant_z = ((-5) - (-7.5)) / timeConstant;
            double rotationConstant = (45-0) / timeConstant;
            //位置變化
            position += new Vector3((float)positionConstant_x, 0, (float)positionConstant_z);
            //角度變化
            transform.eulerAngles += new Vector3(0, (float)rotationConstant, 0);
        }
        else if (cameraPoint[4] <= time && time < cameraPoint[5])
        {
            position = new Vector3(-5f, 15f, -5f); //Camera和Line的相對位置
            transform.eulerAngles = new Vector3(50, 45, 0); //Camera的旋轉角度
        }
        else if (cameraPoint[5] <= time && time < cameraPoint[6])
        {
            double timeConstant = (cameraPoint[6] - cameraPoint[5]) / updateSpeed;
            double positionConstant_x = (0-(-5)) / timeConstant;
            double positionConstant_z = ((-7.5) - (-5)) / timeConstant;
            double rotationConstant = (0-45) / timeConstant;
            //位置變化
            position += new Vector3((float)positionConstant_x, 0, (float)positionConstant_z);
            //角度變化
            transform.eulerAngles += new Vector3(0, (float)rotationConstant, 0);
        }
        else if (cameraPoint[6] <= time && time < cameraPoint[7])
        {
            position = new Vector3(0, 15, -7.5f); //Camera和Line的相對位置
            transform.eulerAngles = new Vector3(50, 0, 0); //Camera的旋轉角度
        }
        else if (cameraPoint[7] <= time && time < cameraPoint[8])
        {
            double timeConstant = (cameraPoint[8] - cameraPoint[7]) / updateSpeed;
            double positionConstant_y = (25-15) / timeConstant;
            double positionConstant_z = (0-(-7.5)) / timeConstant;
            double rotationConstant = (75-50) / timeConstant;
            //位置變化
            position += new Vector3(0, (float)positionConstant_y, (float)positionConstant_z);
            //角度變化
            transform.eulerAngles += new Vector3((float)rotationConstant, 0, 0);
        }
        else if (cameraPoint[8] <= time && time < cameraPoint[9])
        {
            position = new Vector3(0, 25, 0); //Camera和Line的相對位置
            transform.eulerAngles = new Vector3(75, 0, 0); //Camera的旋轉角度
        }
        else if (cameraPoint[9] <= time && time < cameraPoint[10])
        {
            double timeConstant = (cameraPoint[10] - cameraPoint[9]) / updateSpeed;
            double positionConstant_y = (15-25) / timeConstant;
            double positionConstant_z = ((-7.5)-0) / timeConstant;
            double rotationConstant = (50-75) / timeConstant;
            //位置變化
            position += new Vector3(0, (float)positionConstant_y, (float)positionConstant_z);
            //角度變化
            transform.eulerAngles += new Vector3((float)rotationConstant, 0, 0);
        }
        else if (cameraPoint[10] <= time && time < cameraPoint[11])
        {
            position = new Vector3(0, 15f, -7.5f); //Camera和Line的相對位置
            transform.eulerAngles = new Vector3(50, 0, 0); //Camera的旋轉角度
        }
        else if (cameraPoint[11] <= time && time < cameraPoint[12])
        {
            double timeConstant = (cameraPoint[4] - cameraPoint[3]) / updateSpeed;
            double positionConstant_x = ((-5)-0) / timeConstant;
            double positionConstant_z = ((-5) - (-7.5)) / timeConstant;
            double rotationConstant = (45-0) / timeConstant;
            //位置變化
            position += new Vector3((float)positionConstant_x, 0, (float)positionConstant_z);
            //角度變化
            transform.eulerAngles += new Vector3(0, (float)rotationConstant, 0);
        }
        else if (cameraPoint[12] <= time && time < cameraPoint[13])
        {
            position = new Vector3(-5f, 15f, -5f); //Camera和Line的相對位置
            transform.eulerAngles = new Vector3(50, 45, 0); //Camera的旋轉角度
        }
        else if (cameraPoint[13] <= time && time < cameraPoint[14])
        {
            double timeConstant = (cameraPoint[14] - cameraPoint[13]) / updateSpeed;
            double positionConstant_z = (0-(-5)) / timeConstant;
            double rotationConstant = (90 - 45) / timeConstant;
            //位置變化
            position += new Vector3(0, 0, (float)positionConstant_z);
            //角度變化
            transform.eulerAngles += new Vector3(0, (float)rotationConstant, 0);
        }
        else if(cameraPoint[14] <= time && time < cameraPoint[15])
        {
            position = new Vector3(-5f, 15f, 0); //Camera和Line的相對位置
            transform.eulerAngles = new Vector3(50, 90, 0); //Camera的旋轉角度
        }
        else if (cameraPoint[15] <= time && time < cameraPoint[16])
        {
            double timeConstant = (cameraPoint[16] - cameraPoint[15]) / updateSpeed;
            double positionConstant_x = ((-7.5) - (-5)) / timeConstant;
            double positionConstant_y = (2.5 - 15) / timeConstant;
            double rotationConstant = (10 - 50) / timeConstant;
            //位置變化
            position += new Vector3((float)positionConstant_x, (float)positionConstant_y, 0);
            //角度變化
            transform.eulerAngles += new Vector3((float)rotationConstant, 0, 0);
        }
        else if(cameraPoint[16] <= time && time < cameraPoint[17])
        {
            position = new Vector3(-7.5f, 2.5f, 0); //Camera和Line的相對位置
            transform.eulerAngles = new Vector3(10, 90, 0); //Camera的旋轉角度
        }
        else if(cameraPoint[17] <= time && time < cameraPoint[18])
        {
            double timeConstant = (cameraPoint[16] - cameraPoint[15]) / updateSpeed;
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
        transform.localPosition = shareData_Winter.trackCubePosition + position;
    }

    // Update is called once per frame
    void Update()
    {

    }
}
