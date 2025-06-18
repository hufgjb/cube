using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public GameObject[] Cube; // �n�ͦ��� GameObject �w�s��
    public int rows = 4;
    public int columns = 5;
    public float spacing = 0.5f; // ���󤧶������Z
    public Vector3 origin = new Vector3(0, 0, 0);  // ��l���y�Э��I

    private GameObject[,] grid;

    public Text Result;
    // Start is called before the first frame update
    void Start()
    {
        Result.text = string.Empty;
        //���ͼĤH�}�C(2,4);
    }
    void GenrateCube(int r, int c)
    {
        rows = r; columns = c;
        grid = new GameObject[rows, columns];
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                // �p��C�Ӫ��󪺦�m
                Vector3 position = origin + new Vector3(j * spacing, i * spacing, 0);

                // ��Ҥƪ���
                int rnd = Random.Range(0, Cube.Length);
                GameObject newObject = Instantiate(Cube[rnd], position, Quaternion.identity);

                // �N��Ҥƪ�����s�J�}�C
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
