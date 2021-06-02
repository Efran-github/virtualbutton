#include <reg51.h>
#include "delay.h"
#include "KeyScan.h"
#include "InterruptInit.h"

#define uint unsigned int 
#define uchar unsigned char 
uchar _switchFunc=0;
extern uchar _keyClick; //键盘按下标志
uchar _keyNum;//键盘按下数值
uchar code _displayNum[16]={0x77,0x41,0x3b,0x6b,0x4d,0x6e,0x7e,0x43,0x7f,0x6f,0X5f,0X7c,0X36,0X79,0X3e,0X1e};  //共阴数码管显示数字0-F
uchar code _displayFunc[2]={0x77,0x08};//共阴数码管显示功能状态

void main(){
	P0=_displayFunc[0];
	delay(500);
	ExternalIptInit();
	SerialPortInit();
	while(1){
	  _keyNum=KeyScan();
		if(_keyClick==1){
			if(_switchFunc==0){
				P0=_displayNum[_keyNum];
			}//按键显示
			else{
				SerialPortSend(_keyNum);
			}//串口遥控电脑
		}
		delay(10);
	}
	
}//主程序函数

void SwitchFunc() interrupt 0{
	if(_switchFunc==0){
		_switchFunc=1;
		P0=_displayFunc[1];
		delay(10);
	}
	else{
		_switchFunc=0;
		P0=_displayFunc[0];
		delay(10);
	}
}//外部中断0触发

