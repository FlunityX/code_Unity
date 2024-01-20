using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class HealthBar : MonoBehaviour
{
    [SerializeField] float maxHealth; // Giá trị tối đa của máu
    [SerializeField] private float currentHealth; // Giá trị hiện tại của máu
    [SerializeField] Slider slider; // Thành phần Slider để hiển thị thanh máu
    [SerializeField] GameObject character; // Đối tượng nhân vật
    [SerializeField] TextMeshProUGUI _text; // Thành phần TextMeshProUGUI để hiển thị thông tin máu

    private void Start()
    {
        currentHealth = maxHealth; // Đặt giá trị hiện tại của máu là giá trị tối đa ban đầu
        slider.minValue = 0; // Đặt giá trị tối thiểu của Slider là 0
        slider.maxValue = maxHealth; // Đặt giá trị tối đa của Slider là giá trị tối đa của máu ban đầu
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha0))
        {
            IncreaseHealth(10f); // Gọi hàm tăng máu với một lượng là 10 (có thể điều chỉnh)
        }

        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            DecreaseHealth(10f); // Gọi hàm giảm máu với một lượng là 10 (có thể điều chỉnh)
        }

        UpdateHealthBar(); // Cập nhật thanh máu và thông tin máu trong UI
    }

    private void IncreaseHealth(float amount)
    {
        currentHealth += amount; // Tăng giá trị hiện tại của máu

        if (currentHealth >= maxHealth)
        {
            currentHealth = maxHealth; // Giới hạn giá trị hiện tại của máu không vượt quá giá trị tối đa
            character.gameObject.SetActive(true); // Hiển thị nhân vật khi máu đạt giá trị tối đa
        }
    }

    private void DecreaseHealth(float amount)
    {
        currentHealth -= amount; // Giảm giá trị hiện tại của máu

        if (currentHealth <= 0)
        {
            currentHealth = 0; // Giới hạn giá trị hiện tại của máu không nhỏ hơn 0
            character.gameObject.SetActive(false); // Ẩn nhân vật khi máu hết
        }
    }

    private void UpdateHealthBar()
    {
        slider.value = currentHealth; // Cập nhật giá trị của Slider để phản ánh giá trị hiện tại của máu

        if (currentHealth >= 50)
        {
            Image fillImage = slider.fillRect.GetComponent<Image>();
            fillImage.color = Color.green; // Đặt màu fill của Slider thành màu xanh khi máu nhiều hơn hoặc bằng 50
        }
        else
        {
            Image fillImage = slider.fillRect.GetComponent<Image>();
            fillImage.color = Color.red; // Đặt màu fill của Slider thành màu đỏ khi máu ít hơn 50
        }

        _text.text = (currentHealth + "/" + maxHealth).ToString(); // Cập nhật thông tin máu trong UI
    }
}