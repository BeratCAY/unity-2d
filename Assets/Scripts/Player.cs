
using UnityEngine;

public class CircleMovement : MonoBehaviour
{
    [Header("Hareket Ayarları")]
    [SerializeField] private float moveSpeed = 5f;

    private void Update()
    {
        // Klavyeden X (A/D veya Sol/Sağ) ve Y (W/S veya Yukarı/Aşağı) girdilerini al
        float horizontalInput = Input.GetAxisRaw("Horizontal");
        float verticalInput = Input.GetAxisRaw("Vertical");

        // Hareket vektörünü oluştur
        Vector3 moveDirection = new Vector3(horizontalInput, verticalInput, 0f);

        // Çapraz giderken objenin daha hızlı hareket etmesini engelle
        if (moveDirection.magnitude > 1f)
        {
            moveDirection.Normalize();
        }

        // Fizik kullanmadan pozisyonu doğrudan güncelle
        transform.Translate(moveDirection * moveSpeed * Time.deltaTime, Space.World);
    }
}