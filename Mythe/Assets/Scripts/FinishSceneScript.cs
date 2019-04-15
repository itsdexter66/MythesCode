using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
public class FinishSceneScript : MonoBehaviour{ public string tag;private void OnCollisionEnter(Collision other){  if (other.gameObject.tag == tag) {SceneManager.LoadScene("Demo");  } }}
// made this a one liner to trigger a person that reads this. 
