using System;

namespace CallbackDelegate
{
    public class Program
    {
        public delegate void LightControlCallBackMQ(string msg);
        static void Main(string[] args)
        {
            //1.约定回调函数调用的方法
            LightControlCallBackMQ callback;
            callback = ControlSystem.Publish;
            callback += FirstFloorLight.lightController;
            callback += SecondFloorLight.lightController;

            //2.创建控制消息发布的实体对象,并且传入控制命令
            ControlSystem _controlHub = new ControlSystem("打开1楼灯光");
            //3. 发布消息
            _controlHub.CallBack(callback);

            System.Console.ReadKey();
        }
    }
}
