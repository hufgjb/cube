using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public GameObject[] Cube; // 要生成的 GameObject 預製體
    public int rows = 4;
    public int columns = 5;
    public float spacing = 0.5f; // 物件之間的間距
    public Vector3 origin = new Vector3(0, 0, 0);  // 初始的座標原點

    private GameObject[,] grid;

    public Text Result;
    // Start is called before the first frame update
    void Start()
    {
        Result.text = string.Empty;
        //產生敵人陣列(2,4);
    }
    void GenrateCube(int r, int c)
    {
        rows = r; columns = c;
        grid = new GameObject[rows, columns];
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                // 計算每個物件的位置
                Vector3 position = origin + new Vector3(j * spacing, i * spacing, 0);

                // 實例化物件
                int rnd = Random.Range(0, Cube.Length);
                GameObject newObject = Instantiate(Cube[rnd], position, Quaternion.identity);

                // 將實例化的物件存入陣列
                grid[i, j] = newObject;
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (GameObject.FindGameObjectsWithTag("Cube").Length == 0)
        {
            Result.text = "Win";
        }
    }
}
