using UnityEngine;

public class LifeReduction : MonoBehaviour
{
    public int i = 0;
    public GameObject d1;
    public GameObject d2;
    public GameObject d3;
    public GameObject d4;
    public GameObject d5;
    public GameObject d6;
    public GameObject d7;
    public GameObject d8;
    public GameObject d9;
    public GameObject d10;
    public GameObject d11;
    public GameObject d12;
    public GameObject d13;

    public string TagOfDestroyer;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == TagOfDestroyer)
        {
            if (i == 0) {
                i++;
                Destroy(d1);
            }
            else if (i == 1) {
                i++;
                Destroy(d2);
            }
            else if (i == 2) {
                i++;
                Destroy(d3);
            }
            else if (i == 3) {
                i++;
                Destroy(d4);
            }
            else if (i == 4) {
                i++;
                Destroy(d5);
            }
            else if (i == 5) {
                i++;
                Destroy(d6);
            }
            else if (i == 6) {
                i++;
                Destroy(d7);
            }           
            else if (i == 7) {
                i++;
                Destroy(d8);
            }
            else if (i == 8) {
                i++;
                Destroy(d9);
            }       
            else if (i == 9) {
                i++;
                Destroy(d10);
            }
            else if (i == 10){
                i++;
                Destroy(d11);
            }
            else if (i == 11){
                i++;
                Destroy(d12);
            }
            else if (i == 12){
                i++;
                Destroy(d13);
            }
        }
    }

}
