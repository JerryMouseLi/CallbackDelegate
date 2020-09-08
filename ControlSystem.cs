using System;
using System.Drawing;

namespace CallbackDelegate
{
    public class ControlSystem
    {
        public string _cmd;

        public ControlSystem(string cmd)
        {
            _cmd = cmd;  
        }
        public static void Publish(string msg)
        {
            Console.WriteLine("控制系统发布命令："+msg);
        }
        public void CallBack(Program.LightControlCallBackMQ callback)
        {
            callback(_cmd);
        }
    }
}