using UnityEngine;

public class Colission : MonoBehaviour
{
    [SerializeField]private PlayerMovement pm;
    [SerializeField]private Animator playerAnim;

    [SerializeField] PlayerData playerData;
    void Start()
    {
        pm = GetComponent<PlayerMovement>();
    }

    private void OnCollisionEnter(Collision collisionInfo)
    {
        if(collisionInfo.collider.tag == "Enemy")
        {
            pm.enabled = false;
            playerData.SaveData();
            Debug.Log("We Hit");
        }
    }
    void OnTriggerEnter(Collider triggureInfo)
    {
        if(triggureInfo.gameObject.tag == "Point")
        {
            GameManager.inst.IncreamentScore();
        }
    }
}
