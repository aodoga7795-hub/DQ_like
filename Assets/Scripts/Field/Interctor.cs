using UnityEngine;
using UnityEngine.InputSystem;



    /// <summary>
    /// PlayerがInterraction（交流）をするためのClass  
    /// </summary>
public class Interctor : MonoBehaviour
{
    /// <summary>
    /// Distanceの値ｍ先まで交流が
    /// 行えるようにするための変数
    /// </summary>
    public float Distance = 2.0f;

    public LayerMask InteractLayer;

    public float EyeHeight = 0.5f;

    //PlayerInputのＥキーが押されたときに呼ばれます
    public void OnInteract(InputValue value)
    {
        //ボタンが押されてなかったら何もしない
        if(!value.isPressed)
        {
            return;
        }
        TryInteract();
    }
    private void TryInteract()
    {
        Vector3 origin = transform.position + Vector3.up * EyeHeight;

        //光線を発射する
        Ray ray = new Ray(origin, transform.forward);

        //光線がどうなっているかデバッグ用の線を表示する
        Debug.DrawRay(origin, transform.forward * Distance,
            Color.yellow, 0.5f);

        //光線を射出してみて、当たるかどうかの情報
        //光線の長さ、当たるべきＬａｙｅｒ
        if(Physics.Raycast(ray, out RaycastHit hit, Distance,
            InteractLayer))
        {
            //当たったあたり判定からIInteractableを取得する
            var interactable = 
                hit.collider.GetComponent<IInteractable>();

            //Interact（）を発火させる
            interactable?.Interact();
        }


    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
