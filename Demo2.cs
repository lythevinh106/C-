namespace asyncAwait
{
    internal class Demo2
    {

        public async Task runTaskAsync1()
        {
            Task task1 = new Task(() =>
            {
                ExcuteTask("task 1", 6, ConsoleColor.Yellow);

            });

            task1.Start();


            await task1;
            //doan nay thay the cho 2 đoạn code bên dưới và han chế của task vì k thể wait trong hàm
            ///task2.Wait();
            ///return task2; 

        }
        public async Task runTaskAsync2()
        {
            Task task2 = new Task(() =>
            {
                ExcuteTask("task 2", 4, ConsoleColor.Yellow);

            });

            task2.Start();
            await task2;

        }
        public Task runTask()
        {
            Task task2 = new Task(() =>
            {
                ExcuteTask("task 2", 4, ConsoleColor.Yellow);

            });
            task2.Start();
            ////neu su dung wait ở đây thì cản trở luồng chính nên trở thành đồng bộ r. 
            ///sử dụng async await để giải quyết
            //task2.Wait();
            return task2;
        }
        public void ExcuteTask(string name, int duration, ConsoleColor color)
        {
            Console.ResetColor();
            Console.ForegroundColor = color;
            for (int i = 0; i < duration; i++)
            {
                Console.ForegroundColor = color;
                Console.WriteLine($"{name,10}  {i,2}  ");
                Console.ResetColor();
                Thread.Sleep(1000);
            }
            Console.ResetColor();
            Console.WriteLine("ket thuc luong chat " + name + "----------------");
        }
    }



}
