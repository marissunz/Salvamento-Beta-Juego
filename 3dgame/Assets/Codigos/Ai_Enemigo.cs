
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.Rendering;
using UnityEngine.SceneManagement;

public class Ai_Enemigo : MonoBehaviour
{
    public Transform Objetivo;
    public float velocidad;
    public NavMeshAgent IA;
    public GameObject game_over;
    public bool Pausa = false;

    void Update()
    {
        IA.speed = velocidad;
        IA.SetDestination(Objetivo.position);
    }

   
private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            game_over.SetActive(true);
            Time.timeScale = 0f;
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;
            
        }

    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
          
                game_over.SetActive(false);
                Time.timeScale = 1;
                Cursor.visible = false;
                Cursor.lockState = CursorLockMode.Locked;
            
        }
    }




}
