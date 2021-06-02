#ifndef	__INTERRUPTINIT_H__
#define __INTERRUPTINIT_H__


#define uchar unsigned char
#define uint unsigned int

void ExternalIptInit(void);
void SerialPortInit(void);
void SerialPortSend(uchar state);

#endif