namespace CallbackDelegate
{
    public class SecondFloorLight
    {
        public static void lightController(string msg)
        {
            System.Console.WriteLine("2楼订阅者接收到消息："+msg);
            System.Console.WriteLine("2楼不打开灯光");
        }
    }
}