using UnityEngine;
using System.Collections;
using System.Net;
using System.Net.Sockets;
using System.Linq;
using System;
using System.IO;
using System.Text;
public class bulanik : MonoBehaviour
{
    // Use this for initialization
    TcpListener listener;
    string msg;
    void Start()
    {
        //listener=new TcpListener (55001);
        listener = new TcpListener(IPAddress.Parse("127.0.0.1"), 55001);
        listener.Start();
        Debug.LogError("is listening");
    }
    // Update is called once per frame
    void Update()
    {
        if (!listener.Pending())
        {
        }
        else
        {
            Debug.LogError("socket comes");
            TcpClient client = listener.AcceptTcpClient();
            NetworkStream ns = client.GetStream();
            StreamReader reader = new StreamReader(ns);
            
            msg = reader.ReadToEnd();
            Debug.LogError(msg);
        }
    }
}