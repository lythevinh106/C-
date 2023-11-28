namespace asyncAwait
{
    public class Demo1
    {

        public void nauTra()
        {
            var nuoc = nauNuoc();

            Console.WriteLine("lấy cốc ra");
            Console.WriteLine("bo trà vào trong cốc");

            Console.WriteLine("đổ {nuoc} vào cốc đã có trà");
        }


        public string nauNuoc()
        {

            Console.WriteLine("bat dau dun nuoc");
            Console.WriteLine("Chờ nuoc soi");

            Thread.Sleep(5000);
            Console.WriteLine("nước đã sôi xong");



            return " nước sôi";

        }



        public async Task nauTraAsync()
        {
            var nuoc = nauNuocAsync();

            Console.WriteLine("lấy cốc ra");
            Console.WriteLine("bo trà vào trong cốc");
            var nuoc2 = await nuoc;
            Console.WriteLine($"đổ {nuoc2} vào cốc đã có trà-hoàn thành");
        }


        public async Task<string> nauNuocAsync()
        {

            Console.WriteLine("bat dau dun nuoc");
            Console.WriteLine("Chờ nuoc soi");

            await Task.Delay(5000);
            Console.WriteLine("nước đã sôi xong");



            return " nước sôi";

        }
    }
}
