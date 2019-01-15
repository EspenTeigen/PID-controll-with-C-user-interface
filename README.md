# ESP32 PID-controll-with-C#-user-interface
PID-controll with C# user interface using ESP32 and a H-bridge

Writen on behalf of ØStfold University College, faculty of informatics

This is a skeleton for a PID-controller using a DC-motor and a LMD18200 H-bridge. The PID-controller itself is 
not included, and should be coded in C++ in the PID.cpp file that is located in the PID_library folder.

There is a grapchical user interface written in C# that gives the user the possibility to change setpoint, constants and sampling frequency
as well as giving visual feedback of actual position, desired position and controll value for the motor. 

There is no electrical schematics, so basic electronics knowledge is necessary if you want to build this. 
