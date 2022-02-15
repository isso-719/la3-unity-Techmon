using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Count : MonoBehaviour
{
    public int number = 0;
    public Text powerText;
    public Text damageText;
    int total;
    AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void CountUp()
    {
        number += 1;
        powerText.text = number.ToString();
    }

    public void Attack()
    {
        total += number;
        damageText.text = number.ToString();
        audioSource.PlayOneShot(audioSource.clip);
    }
}
