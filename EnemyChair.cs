using UnityEngine;

public class EnemyChair : MonoBehaviour
{
    //化け物
    public GameObject Bakemono;
    //タイマー値保存変数
    public float timer = 0;
    //出すか出さないか
    bool isAppear = false;
    [SerializeField, Header("出現時間")]
    private float appearTime = 10;


    void Update()
    {
        if (timer > appearTime) return;

        if (isAppear == true)
        {
            //タイマー開始
            timer += Time.deltaTime;
            //10秒以上カウントしたか
            if (timer > appearTime)
            {
                //bakemono出す
                Bakemono.SetActive(true);
            }
        }
    }

    private void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Player")
        {
            isAppear = true;
            EventDoor.near = true;
            //Debug.Log("kita");
        }
    }
}