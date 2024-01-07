using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class hak : MonoBehaviour
{
    
    public static int kalanHak = 3; // değişen başka script üzerinden erişiliebilir
    public TextMeshProUGUI hakYazisi;
    public GameObject bitisPaneli;

    
    
    void Update()
    {
        hakYazisi.text = "Hak : " + kalanHak.ToString ();

        if (kalanHak == 0) {
            bitisPaneli.SetActive (true);
            Time.timeScale = 0; //  0 olunca oyun donar
            
        }
    }
}
