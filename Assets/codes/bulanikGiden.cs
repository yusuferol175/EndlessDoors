using System.Collections;
using System.Net;
using System.Net.Sockets;
using System;
using System.IO;
using UnityEngine;
using System.Text;


public class bulanikGiden : MonoBehaviour
{
    // Use this for initialization
    internal Boolean socketReady = false;
    TcpClient mySocket;
    NetworkStream theStream;
    StreamWriter theWriter;
    StreamReader theReader;
    String Host = "localhost";
    Int32 Port = 55000;
    void Start()
    {
        setupSocket();
        Debug.Log("socket is set up");
    }
    // Update is called once per frame
    void Update()
    {
    }


public void setupSocket()
{
    try
    {
        mySocket = new TcpClient(Host, Port);
        theStream = mySocket.GetStream();
        theWriter = new StreamWriter(theStream);
        socketReady = true;
        //writeSocket("yah!! it works");
        Byte[] sendBytes = Encoding.ASCII.GetBytes("16.6"); //--> if the above line doesn't work use this line instead
        mySocket.GetStream().Write(sendBytes, 0, sendBytes.Length); // with this one also
        Debug.Log("socket is sent");
    }
    catch (Exception e)
    {
        Debug.Log("Socket error: " + e);
    }
}
    

}

