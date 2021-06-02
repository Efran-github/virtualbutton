#include <reg51.h>
#include "InterruptInit.h"

void ExternalIptInit(void){
	EA=1;//�����ж�
	EX0=1; //���ⲿ�ж���
	IT0=1; //�����½��ش����ж�
}//�ⲿ�ж����ó�ʼ��

void SerialPortInit(void){
	SCON=0x50;
	TMOD=0x20;
	PCON=0x00;
	TH1=0xfd;
	TL1=0xfd;
	TI=0;
	TR1=1;
	ES=1;
}//����ͨ�����ó�ʼ��

void SerialPortSend(uchar state){
	ES=0;            //�رմ����ж�
	SBUF=state;      //�ӵ�Ƭ���������ݸ�����
	while(!TI);      //�ȴ���Ƭ�����ݷ������
	TI=0;            //������ͱ�־λ
	ES=1;            //�������ж� 
}//����ͨ�ŷ�������
