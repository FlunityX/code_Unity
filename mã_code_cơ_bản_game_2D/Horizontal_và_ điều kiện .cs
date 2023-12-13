
using UnityEngine;

public class bedo : MonoBehaviour
{
    public float movespeed ;
     float bedodichuyen;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        // bấm sang trái -1 , phải +1 . nhập từ bàn phím 

        // GetAxisRaw là 3 vị trí -1 , 0 ,1 nhập từ bàn phím 

        // GetAxis là những vị trí rong khoảng (-1;1)

        bedodichuyen = Input.GetAxisRaw("Horizontal");
       
        //gán movestep bằng công thức dưới 
        //Time.deltaTime trong Unity là một giá trị thời gian thực (real-time) đại diện cho thời gian đã trôi qua kể từ khung hình trước đó. 

        //Nó thường được sử dụng để tính toán các giá trị dựa trên thời gian, như di chuyển, tăng tốc, hoặc thay đổi các giá trị trong mỗi khung hình.

        //Giá trị của Time.deltaTime được tính bằng giây và thường rất nhỏ, thường dao động từ 0.016 đến 0.017 giây (khi chạy ở 60 khung hình/giây) 

        //hoặc khoảng 0.033 giây (khi chạy ở 30 khung hình/giây). Tuy nhiên, giá trị này có thể thay đổi tùy thuộc vào tốc độ khung hình của game.

        //Ví dụ, nếu bạn muốn di chuyển một đối tượng với tốc độ nhất định mỗi khung hình, bạn có thể nhân Time.deltaTime vào tốc độ di chuyển để 

        //đảm bảo rằng đối tượng di chuyển một khoảng cách nhỏ tương ứng với thời gian giữa hai khung hình.

        float movestep = movespeed *bedodichuyen* Time.deltaTime;

        // movespeed ta có thẻ chỉnh trong giao diện Unity

        // transform.position mới = transform.position hiện tại + độ di chuyển theo vecto

        // điều kiện : nếu 1 trong 2 loại đk xảy ra thì sẽ ngừng lại gồm :
        // vật có vị trí  trục x nhỏ hơn -5f và bấm sang trái và lớn hơn hơn 5f bấm sang phải sẽ ko đc thực thi  

        if ((transform.position.x <=-5f && bedodichuyen < 0) || (transform.position.x >= 5f && bedodichuyen > 0  ))
            return;

        // nếu thực thi nó sẽ + 1 giá trị của movestep 

        transform.position = transform.position + new Vector3(movestep,0,0);
    }
}
// chắc chắn vật thể đó di chuyển sang trái phải .