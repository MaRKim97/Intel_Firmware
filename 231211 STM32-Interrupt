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

while (1)
  {
    /* USER CODE END WHILE */

    /* USER CODE BEGIN 3 */
	  //int r = HAL_GPIO_ReadPin(B1_GPIO_Port, B1_Pin);
	  /*if (i != val)  //self code
	  {
		  for (i=0;i<val;i++)
		  {   //Button push = 0, Normal State = 1
			  HAL_GPIO_WritePin(LD2_GPIO_Port, LD2_Pin, 1);  //LED On
			  HAL_Delay(200);  //Delay 1s
			  HAL_GPIO_WritePin(LD2_GPIO_Port, LD2_Pin, 0);  //LED Off
			  HAL_Delay(200);
		  }
	  }*/
	  /*if (flag == 1){  //guide code
		  for (i=0;i<val;i++)
		  {   //Button push = 0, Normal State = 1
			  HAL_GPIO_WritePin(LD2_GPIO_Port, LD2_Pin, 1);  //LED On
			  HAL_Delay(200);  //Delay 1s
			  HAL_GPIO_WritePin(LD2_GPIO_Port, LD2_Pin, 0);  //LED Off
			  HAL_Delay(200);
			  flag = 0;
		  }
	  }*/

	  /*if (val % 2 == 1)   //my code
	  {
		  HAL_GPIO_WritePin(LD2_GPIO_Port, LD2_Pin, 1);
	  }
	  else if (val % 2 == 0)
	  {
		  HAL_GPIO_WritePin(LD2_GPIO_Port, LD2_Pin, 0);
	  }*/

	  //if(val==0) HAL_GPIO_WritePin(LD2_GPIO_Port, LD2_Pin, 1);  //guide code
	  if(val==0) {
		  HAL_GPIO_TogglePin(LD2_GPIO_Port, LD2_Pin);
		  HAL_Delay(200);
	  }
	  else if(val==1) HAL_GPIO_WritePin(LD2_GPIO_Port, LD2_Pin, 0);

  }
  /* USER CODE END 3 */
```
