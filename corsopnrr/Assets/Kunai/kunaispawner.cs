using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class kunaispawner : MonoBehaviour
{
    //l'asset del proiettile
    [SerializeField]
    private GameObject proiettile;

    //punto da dove inizio a sparare
    [SerializeField]
    private Transform firepoint;
      
    //azione che utente fa per sparare
    [SerializeField]
    private InputActionReference ShootAction;
    

    // Update is called once per frame
    void Update()
    {
        //ShootAction.action.WasPresseedThisFrame() =>
       //se ho premuto in questo frame da come valore vero altrimenti da come valore falso


     if(ShootAction.action.WasPressedThisFrame()){
       //instantiate => crea il proiettile nella posizione firePoint.position,con rotazione firePoint.rotation
        Instantiate(proiettile, firepoint.position,firepoint.rotation);
     }    
    }
}
