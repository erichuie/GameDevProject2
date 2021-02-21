using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomTransition : MonoBehaviour
{
    public Camera cam;
    public GameObject nextRoom;
    // private GameObject leftTrigger;
    // private GameObject rightTrigger;
    // private GameObject topTrigger;
    // private GameObject bottomTrigger;

    void OnTriggerEnter2D(Collider2D collision){
        if(collision.CompareTag("Player") && gameObject.tag == "enterRight"){
            cam.transform.position = new Vector3(cam.transform.position.x + (float)17.75, cam.transform.position.y, cam.transform.position.z);
            collision.transform.position = new Vector3(collision.transform.position.x + (float)0.8, collision.transform.position.y, collision.transform.position.z);
            gameObject.transform.parent.gameObject.SetActive(false);
            nextRoom.transform.Find("AllRoomTriggers").gameObject.SetActive(true);
        }
        else if(collision.CompareTag("Player") && gameObject.tag == "enterLeft"){
            cam.transform.position = new Vector3(cam.transform.position.x - (float)17.75, cam.transform.position.y, cam.transform.position.z);
            collision.transform.position = new Vector3(collision.transform.position.x - (float)0.8, collision.transform.position.y, collision.transform.position.z);
            gameObject.transform.parent.gameObject.SetActive(false);
            nextRoom.transform.Find("AllRoomTriggers").gameObject.SetActive(true);
            // rightTrigger = nextRoom.transform.Find("RightWall/RightSceneTrigger").gameObject;
            // rightTrigger.SetActive(true);
        }
        else if(collision.CompareTag("Player") && gameObject.tag == "enterTop"){
            cam.transform.position = new Vector3(cam.transform.position.x, cam.transform.position.y + (float)10, cam.transform.position.z);
            collision.transform.position = new Vector3(collision.transform.position.x, collision.transform.position.y + (float)1.5, collision.transform.position.z);
            gameObject.transform.parent.gameObject.SetActive(false);
            nextRoom.transform.Find("AllRoomTriggers").gameObject.SetActive(true);
            // topTrigger = nextRoom.transform.Find("TopWall/TopSceneTrigger").gameObject;
            // topTrigger.SetActive(true);
        }
        else if(collision.CompareTag("Player") && gameObject.tag == "enterBottom"){
            cam.transform.position = new Vector3(cam.transform.position.x, cam.transform.position.y - (float)10, cam.transform.position.z);
            collision.transform.position = new Vector3(collision.transform.position.x, collision.transform.position.y - (float)1.5, collision.transform.position.z);
            gameObject.transform.parent.gameObject.SetActive(false);
            nextRoom.transform.Find("AllRoomTriggers").gameObject.SetActive(true);
            // bottomTrigger = nextRoom.transform.Find("BottomWall/BottomSceneTrigger").gameObject;
            // bottomTrigger.SetActive(true);
        }
    }
}
