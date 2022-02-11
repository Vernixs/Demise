using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Nextlevel : MonoBehaviour
{
  void OnCollissionEnter(Collision collision)
  {
		SceneManager.LoadScene(2);
  }
}
