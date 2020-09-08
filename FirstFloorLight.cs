namespace CallbackDelegate
{
    public class FirstFloorLight
    {
        public static void lightController(string msg)
        {
            System.Console.WriteLine("1楼订阅者接收到消息："+msg);
            System.Console.WriteLine("1楼打开灯光");
        }
    }
}