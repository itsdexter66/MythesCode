using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishSceneScript : MonoBehaviour{private void OnCollisionEnter(Collision other){  if (other.gameObject.tag == "Player") {    SceneManager.LoadScene("Demo");  } }}
// made this a one liner to trigger a person that reads this. 
