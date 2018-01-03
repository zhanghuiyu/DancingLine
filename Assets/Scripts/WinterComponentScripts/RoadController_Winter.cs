using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoadController_Winter : MonoBehaviour {
    //節奏點的x座標
    double[] xPos = new double[] {0, 3.5, 3.5, 7.5, 7.5, 11.5, 11.5, 15.5, 15.5, 20,
20, 24, 24, 40.5, 40.5, 45, 45, 49.5, 49.5, 54,
54, 58.5, 58.5, 62.5, 62.5, 67.5, 67.5, 72, 72, 76,
76, 84, 84, 88, 88, 92.5, 92.5, 95, 95, 97,
97, 102, 102, 111, 111, 115.5, 115.5, 120.5, 120.5, 127.5,
127.5, 129.5, 129.5, 131.5, 131.5, 135.5, 135.5, 140, 140, 144,
144, 148.5, 148.5, 152, 152, 156, 156, 160.5, 160.5, 177.5,
177.5, 181.5, 181.5, 186, 186, 190, 190, 194.5, 194.5, 199,
199, 203.5, 203.5, 208, 208, 212.5, 212.5, 221, 221, 225.5,
225.5, 230, 230, 232.5, 232.5, 234.5, 234.5, 239.5, 239.5, 248,
248, 253, 253, 257, 257, 265, 265, 267.5, 267.5, 269.5,
269.5, 273.5, 273.5, 278.5, 278.5, 282.5, 282.5, 291, 291, 295.5,
295.5, 300, 300, 309, 309, 313.5, 313.5, 318, 318, 322,
322, 326.5, 326.5, 330.5, 330.5, 335, 335, 352.5, 352.5, 356.5,
356.5, 361, 361, 365.5, 365.5, 370, 370, 374.5, 374.5, 379,
379, 383, 383, 387.5, 387.5, 395.5, 395.5, 400, 400, 404.5,
404.5, 406.5, 406.5, 408.5, 408.5, 413, 413, 421, 421, 425,
425, 430, 430, 438.5, 438.5, 441, 441, 443, 443, 447.5,
447.5, 452, 452, 456.5, 456.5, 464.5, 464.5, 468.5, 468.5, 473.5,
473.5, 475.5, 475.5, 477.5, 477.5, 482, 482, 490, 490, 494,
494};

    //節奏點的z座標
    double[] zPos = new double[] {9, 9, 13, 13, 17, 17, 21.5, 21.5, 25.5, 25.5,
30, 30, 34.5, 34.5, 39, 39, 43, 43, 47, 47,
51.5, 51.5, 56, 56, 60, 60, 76, 76, 85, 85,
89.5, 89.5, 94, 94, 102.5, 102.5, 105, 105, 107, 107,
110.5, 110.5, 114.5, 114.5, 118.5, 118.5, 127, 127, 131, 131,
136, 136, 138, 138, 140.5, 140.5, 145, 145, 149, 149,
154, 154, 158, 158, 162.5, 162.5, 167, 167, 172, 172,
176, 176, 180.5, 180.5, 184.5, 184.5, 188.5, 188.5, 193, 193,
197, 197, 214.5, 214.5, 223, 223, 226.5, 226.5, 231, 231,
239, 239, 241, 241, 243, 243, 247, 247, 251, 251,
255, 255, 263, 263, 268, 268, 272.5, 272.5, 274.5, 274.5,
277, 277, 281, 281, 289.5, 289.5, 294, 294, 298, 298,
306, 306, 310.5, 310.5, 314.5, 314.5, 319, 319, 323, 323,
327, 327, 331, 331, 335, 335, 339.5, 339.5, 344, 344,
348, 348, 352.5, 352.5, 356, 356, 360.5, 360.5, 364.5, 364.5,
382, 382, 391, 391, 395, 395, 399.5, 399.5, 408, 408,
410, 410, 412.5, 412.5, 416.5, 416.5, 421, 421, 425.5, 425.5,
433.5, 433.5, 437.5, 437.5, 442, 442, 444, 444, 446, 446,
450, 450, 458.5, 458.5, 463, 463, 467.5, 467.5, 475.5, 475.5,
478, 478, 480, 480, 484.5, 484.5, 489, 489, 493.5, 493.5,
501.5};

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
            //開頭 要改
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
            for (double x = xPos[xPos.Length - 1]; x < 660; x = x + interval)
            {
                GameObject subLeftRock = Instantiate(leftRock);
                subLeftRock.transform.localPosition = new Vector3((float)(x - rockDelta), 0.5f, (float)(zPos[zPos.Length - 1] + rockDelta));
            }
            for (double x = xPos[xPos.Length - 1]; x < 650; x = x + interval)
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
