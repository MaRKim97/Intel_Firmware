# Intel_Firmware
## 231211 STM32-Interrupt
```
/* Private user code ---------------------------------------------------------*/
/* USER CODE BEGIN 0 */
int val = 0;
//int flag = 1;
void HAL_GPIO_EXTI_Callback(uint16_t GPIO_Pin)
{
	//if (val == 0) val = 1; else val = 0;
	//val = !val;
	//val++; ->my method
	//if(val%5==0) val = 0;
	//if(val++>5) val = 0;
	//flag = 1;

	val = HAL_GPIO_ReadPin(B1_GPIO_Port, B1_Pin);
	//if(val == 0) val == 1; else val = 0;
	//if (r == 0) val = 0; else val = 1;  //val and r are same
}
/* USER CODE END 0 */
```
