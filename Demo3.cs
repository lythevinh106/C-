namespace asyncAwait
{
    public class Demo3
    {

        public async Task CallApiAsync1()
        {
            Console.WriteLine("Start CallApiAsync1");

            using (var client = new HttpClient())
            {
                // Gọi API và đợi phản hồi
                var response = await client.GetAsync("https://my-json-server.typicode.com/typicode/demo/comments");

                // Xử lý phản hồi
                if (response.IsSuccessStatusCode)
                {
                    var content = await response.Content.ReadAsStringAsync();
                    Console.WriteLine("API response received call1 api1: " + content);
                }
                else
                {
                    Console.WriteLine("Failed to call API");
                }

            }

            Console.WriteLine("End CallApiAsync1");
        }



        public async Task CallApiAsync2()
        {
            Console.WriteLine("Start CallApiAsync2");

            using (var client = new HttpClient())
            {
                // Gọi API và đợi phản hồi
                var response = await client.GetAsync("https://my-json-server.typicode.com/typicode/demo/posts");

                // Xử lý phản hồi
                if (response.IsSuccessStatusCode)
                {
                    var content = await response.Content.ReadAsStringAsync();
                    Console.WriteLine("API response received: call api2" + content);
                }
                else
                {
                    Console.WriteLine("Failed to call API");
                }
            }

            Console.WriteLine("End CallApiAsync2");
        }



        public async Task CallApiAsync3()
        {
            Console.WriteLine("Start CallApiAsync3");

            using (var client = new HttpClient())
            {
                // Gọi API và đợi phản hồi
                var response = await client.GetAsync("https://my-json-server.typicode.com/typicode/demo/profile");

                // Xử lý phản hồi
                if (response.IsSuccessStatusCode)
                {
                    var content = await response.Content.ReadAsStringAsync();
                    Console.WriteLine("API response received: call api 3" + content);
                }
                else
                {
                    Console.WriteLine("Failed to call API");
                }
            }

            Console.WriteLine("End CallApiAsync3");
        }

        public void CallApi4()
        {
            Console.WriteLine("Start CallApi4");

            using (var client = new HttpClient())
            {
                // Gọi API và đợi phản hồi
                var response = client.GetAsync("https://my-json-server.typicode.com/typicode/demo/comments").Result;

                // Xử lý phản hồi
                if (response.IsSuccessStatusCode)
                {
                    var content = response.Content.ReadAsStringAsync().Result;
                    Console.WriteLine("API response received call1 api4: " + content);
                }
                else
                {
                    Console.WriteLine("Failed to call API");
                }
            }

            Console.WriteLine("End CallApi4");
        }



    }
}
