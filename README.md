# IoT-Solutions
Alternative solutions to connect Beckhoff CX9020 to Azure IoT Hub

IoT-Example (TwinCAT project)
Contains example implementation of HTTP client and some sample code. You need to install TF6310 | TC3 TCP/IP into target machine. Example send HTTP post data into our azure and there’s PHP script receiving & storing the data into txt-file: http://bafdemo.cloudapp.net/demot/rest-demo/post_data.txt
 
AdsMqtt (C#/Windows Forms application)
In this example data is read from TwinCAT via Ads protocol. The example is written using Visual Studio 2013 & .NET Framework 4.5, but should be compatible in project level also to other Visual Studio versions also (and also I think you can build the example using .NET FW 4). More C#/Ads examples can be found here: https://infosys.beckhoff.com/content/1033/tc3_adssamples_net/html/twincat.ads.setuptc3.htm?id=1554183909579087968
Additionally, data is published to public MQTT broker (iot.eclipse.org) using paho’s .NET MQTT lib: https://eclipse.org/paho/clients/dotnet/
