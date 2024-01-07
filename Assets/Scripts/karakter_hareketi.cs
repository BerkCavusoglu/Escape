using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class karakter_hareketi : MonoBehaviour
{
    public float hareketHizi; 
    public static int kalanHak; 
    

    
    void Update()
    {
        float hiz = hareketHizi * Input.GetAxis("Horizontal"); //Yatay düzlemde hareket istiyoruz.
        transform.Translate(hiz * Time.deltaTime, 0, 0); //karakteri oynat y ve z de hareket yok sadece x de hareket
        //Time.deltaTime:bütün cihazlarda aynı çalışmasını sağlar 

    }
}
