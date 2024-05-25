using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bai : MonoBehaviour
{
    // Start is called before the first frame update
    public AudioSource D;
    public AudioSource R;
    public AudioSource M;
    public AudioSource P;
    public AudioSource S;
    public AudioSource L;
    public AudioSource I;
    public AudioSource O;

    void Start()
    {
        Debug.Log("star");
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.D)) 
        {
            Debug.Log("Press D");
            D.Play();
        } if(Input.GetKeyDown(KeyCode.R)) 
        {
            Debug.Log("PressR");
            R.Play();
        }if(Input.GetKeyDown(KeyCode.M)) 
        {
            Debug.Log("Press M");
            M.Play();
        }if(Input.GetKeyDown(KeyCode.P)) 
        {
            Debug.Log("Press P");
            P.Play();
        }if(Input.GetKeyDown(KeyCode.S)) 
        {
            Debug.Log("Press S");
            S.Play();
        }if(Input.GetKeyDown(KeyCode.L)) 
        {
            Debug.Log("Press L");
            L.Play();
        }if (Input.GetKeyDown(KeyCode.I) )
        {
            Debug.Log("Press I");
            I.Play();
        }if (Input.GetKeyDown(KeyCode.O) )
        {
            Debug.Log("Press O");
            O.Play();
        }
    }
}
