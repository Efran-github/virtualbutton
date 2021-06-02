#include <reg51.h>
#include "InterruptInit.h"

void ExternalIptInit(void){
	EA=1;//开总中断
	EX0=1; //开外部中断零
	IT0=1; //请求下降沿触发中断
}//外部中断设置初始化

void SerialPortInit(void){
	SCON=0x50;
	TMOD=0x20;
	PCON=0x00;
	TH1=0xfd;
	TL1=0xfd;
	TI=0;
	TR1=1;
	ES=1;
}//串口通信设置初始化

void SerialPortSend(uchar state){
	ES=0;            //关闭串口中断
	SBUF=state;      //从单片机发送数据给电脑
	while(!TI);      //等待单片机数据发送完毕
	TI=0;            //清除发送标志位
	ES=1;            //开串口中断 
}//串口通信发送数据
