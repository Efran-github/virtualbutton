#include <reg51.h>
#include "delay.h"
#include "KeyScan.h"
uchar _keyClick;
uchar KeyScan(void){
			 uchar temp,num;
			 _keyClick=0;
			 P1=0Xef;//扫描第一行
       temp=P1;
			 if(temp!=0xef)	{
					delay(10);//去除抖动 10ms
					temp=P1;
					if(temp!=0xef){	
						 while(!(P1==0xef));						
						 switch(temp){
						 case 0xee: num=0;break;
						 case 0xed: num=1;break;
						 case 0xeb: num=2;break;
						 case 0xe7: num=3;break;
						 }
						 _keyClick=1;						 
					}
			}     
////*************************************************************************
				P1=0Xdf;//扫描第二行
				temp=P1;
				if(temp!=0xdf)	{
					delay(10);//去除抖动 10ms
					temp=P1;
					if(temp!=0xdf){		           
						while(!(P1==0xdf));
						switch(temp){
							case 0xde: num=4;break;
							case 0xdd: num=5;break;
							case 0xdb: num=6;break;
							case 0xd7: num=7;break;
						  }
						  _keyClick=1;								
					}
			}     
////*************************************************************************
				P1=0Xbf;//扫描第三行
				temp=P1;
			  if(temp!=0xbf)	 {
			    delay(10);//去除抖动 10ms
					temp=P1;
					if(temp!=0xbf){		           
						 while(!(P1==0xbf));
						 switch(temp){
							 case 0xbe: num=8;break;
							 case 0xbd: num=9;break;
							 case 0xbb: num=10;break;
							 case 0xb7: num=11;break;
						   }		  
						   _keyClick=1;								 
				}
		  }      
////*************************************************************************
				P1=0X7f;//扫描第四行
				temp=P1;
			  if(temp!=0x7f)	 {
					delay(10);//去除抖动 10ms
					temp=P1;
					if(temp!=0x7f){		           
						 while(!(P1==0x7f));
						 switch(temp){
							 case 0x7e: num=12;break;
							 case 0x7d: num=13;break;
							 case 0x7b: num=14;break;
							 case 0x77: num=15;break;
						   }		
						  _keyClick=1;								 
					}
			 }
			return num;	
	
}//键盘扫描