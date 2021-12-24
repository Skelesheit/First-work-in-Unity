using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class buttons : MonoBehaviour
{
    [SerializeField] public bool Ren;
    [SerializeField] public GameObject Cube_1_1;
    [SerializeField] public GameObject Cube_1_2;
    [SerializeField] public GameObject Cube_1_3;
    [SerializeField] public GameObject Cube_1_4;
    [SerializeField] public GameObject Cube_2_1;
    [SerializeField] public GameObject Cube_2_2;
    [SerializeField] public GameObject Cube_2_3;
    [SerializeField] public GameObject Cube_2_4;
    [SerializeField] public GameObject Cube_2_5;
    [SerializeField] public InputField field;
    
    private string request;

    private GameObject cube1_1;
    private GameObject cube1_2;
    private GameObject cube1_3;
    private GameObject cube1_4;
    private GameObject cube2_1;
    private GameObject cube2_2;
    private GameObject cube2_3;
    private GameObject cube2_4;
    private GameObject cube2_5;


    public void HideAllRooms()
    {
        cube1_1.SetActive(false);
        cube1_2.SetActive(false);
        cube1_3.SetActive(false);
        cube1_4.SetActive(false);
        cube2_1.SetActive(false);
        cube2_2.SetActive(false);
        cube2_3.SetActive(false);
        cube2_4.SetActive(false);
        cube2_5.SetActive(false);
    }
    public void FindRoom(int floor, int room)
    {
        if ( (floor > 0) & (room > 0) )
        {
            if ((floor == 1) & (room == 1))
            {
                gameObject.transform.position = cube1_1.transform.position;
                cube1_1.SetActive(true);
            }
        
            if ((floor == 1) & (room == 2))
            {
                gameObject.transform.position = cube1_2.transform.position;
                cube1_2.SetActive(true);
            }

            if ((floor == 1) & (room == 3))
            {
                gameObject.transform.position = cube1_3.transform.position;
                cube1_3.SetActive(true);
            }
            if ((floor == 1) & (room == 4))
            {
                gameObject.transform.position = cube1_4.transform.position;
                cube1_4.SetActive(true);
            }

                
            if ((floor == 2) & (room == 1))
            {
                gameObject.transform.position = cube2_1.transform.position;
                cube2_1.SetActive(true);
            }

            if ((floor == 2) & (room == 2))
            {
                gameObject.transform.position = cube2_2.transform.position;
                cube2_2.SetActive(true);
            }

            if ((floor == 2) & (room == 3))
            {
                gameObject.transform.position = cube2_3.transform.position;
                cube2_3.SetActive(true);
            }

            if ((floor == 2) & (room == 4))
            {
                
                gameObject.transform.position = cube2_4.transform.position;
                cube2_4.SetActive(true);

            }

            if ((floor == 2) & (room == 5))
            {
                
                gameObject.transform.position = cube2_5.transform.position;
                cube2_5.SetActive(true);

            }
        }
        


        
    }

    private void Start()
    {
        cube1_1 = Instantiate(Cube_1_1, Cube_1_1.transform.position, Quaternion.identity);

        cube1_2 = Instantiate(Cube_1_2, Cube_1_2.transform.position, Quaternion.identity);

        cube1_3 = Instantiate(Cube_1_3, Cube_1_3.transform.position, Quaternion.identity);

        cube1_4 = Instantiate(Cube_1_4, Cube_1_4.transform.position, Quaternion.identity);

        cube2_1 = Instantiate(Cube_2_1, Cube_2_1.transform.position, Quaternion.identity);

        cube2_2 = Instantiate(Cube_2_2, Cube_2_2.transform.position, Quaternion.identity);

        cube2_3 = Instantiate(Cube_2_3, Cube_2_3.transform.position, Quaternion.identity);

        cube2_4 = Instantiate(Cube_2_4, Cube_2_4.transform.position, Quaternion.identity);

        cube2_5 = Instantiate(Cube_2_5, Cube_2_5.transform.position, Quaternion.identity);        

        HideAllRooms();
    }


    int[] light = new int[] {1, 1};


    


    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Z))
        {
            transform.position = new Vector3(-3, 7, -90);
        }

        if (Input.GetKey(KeyCode.X))
        {
            transform.position = new Vector3(500, 7, -70);
        }

        if (Input.GetKeyDown(KeyCode.LeftAlt))
        {
            HideAllRooms();
            request = field.text;
            int floor = 0;
            int room = 0;

            try
            {
                floor = int.Parse(request[0].ToString());
                room = int.Parse(request[2].ToString());
            }
            catch
            {

                Debug.Log("incorrect input");
        
            }

            FindRoom(floor, room);
            field.SetTextWithoutNotify("");

        }
    }
}
