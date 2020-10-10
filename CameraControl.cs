using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//класс для переключения на другую камеру и поворота камеры
public class CameraControl: MonoBehaviour {

    bool flag;
    public GameObject camera1;
    public GameObject camera2;
    public GameObject btLeftRotate, btRightRotate, Panel1, Panel2;  

    public void Start()
    {
        flag = false;
    }
    public void GoAnotherCamera()
    {
        if (flag == false) {
            camera1.SetActive(false);
            camera2.SetActive(true);
            flag=true;
            Debug.Log("Переключение на камеру 2" );
            btLeftRotate.SetActive(false);
            btRightRotate.SetActive(false);
            Panel1.SetActive(false);
            Panel2.SetActive(false);
        }
      else  {
            camera2.SetActive(false);
            camera1.SetActive(true);
            flag =false;
            Debug.Log("Переключение на камеру 1");
            btLeftRotate.SetActive(true);
            btRightRotate.SetActive(true);
            Panel1.SetActive(true);
            Panel2.SetActive(true);
        }
    }

    //поворот камеры
  public void CameraRotateLeft() {
        Camera.main.transform.Rotate( 0, -200 * Time.deltaTime, 0);
    }
    public void CameraRotateRight()
    {
        Camera.main.transform.Rotate(0, 200 * Time.deltaTime, 0);
    }  
}
