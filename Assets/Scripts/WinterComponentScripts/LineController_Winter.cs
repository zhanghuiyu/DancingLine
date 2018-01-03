using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using System.Threading;
using System;
using System.Diagnostics;

public class shareData_Winter
{
    public static bool gameStart = false; //紀錄遊戲是不是在進行
    public static float movingSpeed = 0.05f; //Camera和Line移動的速度
    public static Vector3 trackCubePosition; //動態生成Line時，當下Cube應該要放在哪裡
    public static Stopwatch timer = new Stopwatch(); //計時器
}

[RequireComponent(typeof(Rigidbody))]
public class LineController_Winter : MonoBehaviour {
    public AudioSource BGM; //背景音樂
    Rigidbody lineRigidbody;
    MeshRenderer lineMeshRender;
    MeshRenderer cubeMeshRender;
    public GameObject cubeGameObject; //用來動態生成Line的Cube
    Vector3 direction; //調整Cube要放在哪裡
    int turnState; //紀錄目前Line的轉向狀態

    // Use this for initialization
    void Start()
    {
        //設定Line剛體
        lineRigidbody = GetComponent<Rigidbody>();

        //設定Line顏色
        lineMeshRender = GetComponent<MeshRenderer>();
        lineMeshRender.material.color = Color.blue;
        cubeMeshRender = cubeGameObject.GetComponent<MeshRenderer>();
        cubeMeshRender.material.color = Color.blue;

        //動態生成Line
        shareData_Winter.trackCubePosition = transform.localPosition; //將trackCubePosition設為Line的起點
        InvokeRepeating("createLine", 0.0f, shareData_Winter.movingSpeed);
    }

    void createLine()
    {
        if (shareData_Winter.gameStart && cubeGameObject != null)
        {
            GameObject newCubeGameObject = Instantiate(cubeGameObject);
            switch (turnState)
            {
                case 0:
                    direction.x = 0.5f;
                    direction.y = 0;
                    direction.z = 0;
                    break;
                case 1:
                    direction.x = 0;
                    direction.y = 0;
                    direction.z = 0.5f;
                    break;
            }
            newCubeGameObject.transform.localPosition = shareData_Winter.trackCubePosition + direction;
            shareData_Winter.trackCubePosition = newCubeGameObject.transform.localPosition;
            /*之後要記得補上把Cube刪掉的部分*/
            Destroy(newCubeGameObject, 5);
        }
    }

    // Update is called once per frame
    void Update()
    {
        //按滑鼠左鍵改變Line跑的方向
        if (Input.GetMouseButtonDown(0))
        {
            //當第一次按下滑鼠左鍵的時候整個遊戲才開始運作
            if (!shareData_Winter.gameStart)
            {
                BGM.Play(); //撥放音樂
                shareData_Winter.timer.Start(); //按下計時
                shareData_Winter.gameStart = true;
            }

            //變更Line轉彎方向
            switch (turnState)
            {
                case 0:
                    turnState = 1;
                    break;
                case 1:
                    turnState = 0;
                    break;
            }
        }
    }
}