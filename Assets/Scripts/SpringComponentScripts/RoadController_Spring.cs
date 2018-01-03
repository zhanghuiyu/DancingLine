using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoadController_Spring : MonoBehaviour {
    //節奏點的x座標
    double[] xPos = new double[] {0, 4.5, 4.5, 9, 9, 16, 16, 18, 18, 20,
20, 27, 27, 33.5, 33.5, 53, 53, 58, 58, 62.5,
62.5, 65.5, 65.5, 67.5, 67.5, 70.5, 70.5, 73.5, 73.5, 76.5,
76.5, 81, 81, 86, 86, 93.5, 93.5, 95.5, 95.5, 97.5,
97.5, 104.5, 104.5, 111, 111, 130, 130, 134.5, 134.5, 139.5,
139.5, 142, 142, 144.5, 144.5, 147.5, 147.5, 150, 150, 152.5,
152.5, 157.5, 157.5, 162.5, 162.5, 169, 169, 171.5, 171.5, 173.5,
173.5, 180, 180, 182.5, 182.5, 185, 185, 204, 204, 208.5,
208.5, 213.5, 213.5, 216, 216, 218, 218, 220.5, 220.5, 223,
223, 225.5, 225.5, 230.5, 230.5, 235.5, 235.5, 240.5, 240.5, 243,
243, 246, 246, 248.5, 248.5, 251.5, 251.5, 254, 254, 257,
257, 262.5, 262.5, 267, 267, 272, 272, 279, 279, 281.5,
281.5, 283.5, 283.5, 295, 295, 297.5, 297.5, 316.5, 316.5, 322,
322, 327, 327, 330, 330, 332.5, 332.5, 335.5, 335.5, 338.5,
338.5, 342, 342, 346.5, 346.5, 351, 351, 357.5, 357.5, 360.5,
360.5, 363.5, 363.5};

    //節奏點的z座標
    double[] zPos = new double[] {13.5, 13.5, 18, 18, 23.5, 23.5, 26.5, 26.5, 29, 29,
32, 32, 34.5, 34.5, 37, 37, 41.5, 41.5, 46.5, 46.5,
53.5, 53.5, 56, 56, 58, 58, 65, 65, 71.5, 71.5,
90.5, 90.5, 95.5, 95.5, 100, 100, 102.5, 102.5, 105, 105,
107.5, 107.5, 110.5, 110.5, 113.5, 113.5, 118.5, 118.5, 123, 123,
130.5, 130.5, 133, 133, 135, 135, 146.5, 146.5, 149, 149,
168, 168, 172.5, 172.5, 177.5, 177.5, 180, 180, 182.5, 182.5,
185.5, 185.5, 188.5, 188.5, 190.5, 190.5, 193.5, 193.5, 198, 198,
203, 203, 210, 210, 212.5, 212.5, 215, 215, 222, 222,
229.5, 229.5, 238.5, 238.5, 243.5, 243.5, 248, 248, 250.5, 250.5,
256.5, 256.5, 259, 259, 261.5, 261.5, 268, 268, 275, 275,
284, 284, 288.5, 288.5, 293.5, 293.5, 298, 298, 300.5, 300.5,
303, 303, 306, 306, 308.5, 308.5, 311, 311, 315.5, 315.5,
320, 320, 326.5, 326.5, 329, 329, 331, 331, 337, 337,
343.5, 343.5, 363, 363, 368, 368, 372.5, 372.5, 375.5, 375.5,
378, 378, 382.5};

    //Rock的變數
    public GameObject leftRock, rightRock;
    double rockDelta = 3.5; //路的寬度
    float interval = 2;

    //Tree的變數
    public GameObject[] tree = new GameObject[10];
    System.Random rand = new System.Random();
    int treeKind;
    double treeDelta = 7;

    // Use this for initialization
    void Start()
    {
        //產生Rock和Tree
        if ((leftRock != null) && (rightRock != null) && (tree != null))
        {
            //開頭
            for (double z = -rockDelta; z < zPos[0]; z = z + interval)
            {
                GameObject subLeftRock = Instantiate(leftRock);
                subLeftRock.transform.localPosition = new Vector3((float)(0 - rockDelta), 0.5f, (float)(z + rockDelta));
            }
            for (double z = rockDelta; z < zPos[0]; z = z + interval)
            {
                GameObject subRightRock = Instantiate(rightRock);
                subRightRock.transform.localPosition = new Vector3((float)(0 + rockDelta), 0.5f, (float)(z - rockDelta));
            }

            //中間
            for (int i = 0, j = 0; i < xPos.Length; i++, j++)
            {
                //隨機決定Tree種類
                treeKind = rand.Next(0, 10);

                //先產生節奏點上的Rock以及Tree
                GameObject newLeftRock = Instantiate(leftRock);
                newLeftRock.transform.localPosition = new Vector3((float)(xPos[i] - rockDelta), 0.5f, (float)(zPos[j] + rockDelta));
                GameObject newRightRock = Instantiate(rightRock);
                newRightRock.transform.localPosition = new Vector3((float)(xPos[i] + rockDelta), 0.5f, (float)(zPos[j] - rockDelta));
                GameObject newLeftTree = Instantiate(tree[treeKind]);
                newLeftTree.transform.localPosition = new Vector3((float)(xPos[i] - treeDelta), 0.5f, (float)(zPos[j] + treeDelta));
                GameObject newRightTree = Instantiate(tree[treeKind]);
                newRightTree.transform.localPosition = new Vector3((float)(xPos[i] + treeDelta), 0.5f, (float)(zPos[j] - treeDelta));

                //再產生節奏點之間的Rock
                if ((i - 1) >= 0 && (j - 1) >= 0)
                {
                    //往Vector3.forward方向走
                    if ((i % 2 == 0))
                    {
                        for (double z = zPos[j - 1]; z < zPos[j]; z = z + interval)
                        {
                            GameObject subLeftRock = Instantiate(leftRock);
                            subLeftRock.transform.localPosition = new Vector3((float)(xPos[i - 1] - rockDelta), 0.5f, (float)(z + rockDelta));
                            GameObject subRightRock = Instantiate(rightRock);
                            subRightRock.transform.localPosition = new Vector3((float)(xPos[i - 1] + rockDelta), 0.5f, (float)(z - rockDelta));
                        }
                    }
                    //往Vector3.right方向走
                    else if ((i % 2 == 1))
                    {
                        for (double x = xPos[i - 1]; x < xPos[i]; x = x + interval)
                        {
                            GameObject subLeftRock = Instantiate(leftRock);
                            subLeftRock.transform.localPosition = new Vector3((float)(x - rockDelta), 0.5f, (float)(zPos[j - 1] + rockDelta));
                            GameObject subRightRock = Instantiate(rightRock);
                            subRightRock.transform.localPosition = new Vector3((float)(x + rockDelta), 0.5f, (float)(zPos[j - 1] - rockDelta));
                        }
                    }
                }
            }

            //結尾
            for (double x = xPos[xPos.Length - 1]; x < 500; x = x + interval)
            {
                GameObject subLeftRock = Instantiate(leftRock);
                subLeftRock.transform.localPosition = new Vector3((float)(x - rockDelta), 0.5f, (float)(zPos[zPos.Length - 1] + rockDelta));
            }
            for (double x = xPos[xPos.Length - 1]; x < 490; x = x + interval)
            {
                GameObject subRightRock = Instantiate(rightRock);
                subRightRock.transform.localPosition = new Vector3((float)(x + rockDelta), 0.5f, (float)(zPos[zPos.Length - 1] - rockDelta));
            }
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
