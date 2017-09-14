using UnityEngine;

public class EnemyHumanfigure : MonoBehaviour
{
    public GameObject Bakemono;
    public static bool isMove = false;
    public Soundcontroller soucon;
    public AudioSource audios;

    private void Start()
    {
        audios.clip = soucon.audioclip01[2];
        Bakemono.SetActive(false);
    }

    private void OnTriggerExit(Collider col)
    {
        if (Bakemono != null && col.gameObject.tag == "Player")
        {
            Bakemono.SetActive(true);
            audios.Play();
            //Debug.Log("吾輩はママであるっ!!!!!");
        }
    }

}

