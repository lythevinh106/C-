using System.Diagnostics;

namespace asyncAwait
{
    class Program
    {
        static async Task Main(string[] args)
        {
            //demo async 
            //Demo1 demo1 = new Demo1();

            ///se doi 5s để nước đun xong mới chạy tiếp đc (k su dụng async nen bị chặn luồng)
            //demo1.nauTra();

            //su dung async nen k can doi 5s nua
            //await demo1.nauTraAsync();


            ///////////demo task
            Demo2 demo2 = new Demo2();

            ///k co task nen chay mất 27s

            //demo2.ExcuteTask("task 1", 10, ConsoleColor.Red);
            //demo2.ExcuteTask("task 2", 9, ConsoleColor.Blue);
            //demo2.ExcuteTask("task 3", 8, ConsoleColor.Yellow);

            ///co task nen chay mat có 10s

            //Task task1 = new Task(() =>
            //{
            //    demo2.ExcuteTask("task 1", 5, ConsoleColor.Red);

            //});

            //task1.Start();



            //Task task2 = demo2.runTask();


            //task2.Wait();

            //task1.Wait();


            //neu k await thi đoan nay se chay truoc
            //Console.WriteLine("chay xong ct tassk");





            ////demo assyn await



            //Task task1 = demo2.runTaskAsync1();
            //Task task2 = demo2.runTaskAsync2();


            //Console.WriteLine("chay xong ct assync");


            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();






            Demo3 demo3 = new Demo3();

            /*
                        demo3.CallApi4();
                        demo3.CallApi4();

                        doan nay se k chan luong chinh: 
                       n  o su dụng giong nhu task(k su dung await nen ham se tra ve 1 task  ) vi k co await
                         
                        demo3.CallApiAsync1();

                        demo3.CallApi4();
                        demo3.CallApi4();
            */


            /* doan nay se chay đa luồng (nên k kiểm soát được luồng nào sẽ hoàn thành trước apply send mail)
                        demo3.CallApiAsync1();
                        demo3.CallApiAsync2();
                        demo3.CallApiAsync3();
            */


            /*
            demo3.CallApiAsync1();
            demo3.CallApiAsync1();

            await demo3.CallApiAsync2();

            doan nay chi chay bat dong bo khi   await demo3.CallApiAsync2() chay xonng
            demo3.CallApiAsync3();
            demo3.CallApiAsync3();


            */
            /*
                        demo3.CallApiAsync1();
                        demo3.CallApiAsync1();

                        await demo3.CallApiAsync2();

                        demo3.CallApi4();
                        demo3.CallApi4();
            */


            //trong js là đơn luồng nên code bất đồng bộ sẽ chạy sau tất cả luồng bất đồng bộ,
            //  còn trong c# thì nếu code đồng bộ chạy thì sẽ chay song song vs luồng chính nen su dung await de kiem soat

            stopwatch.Stop();
            Console.WriteLine($"Thời gian chạy: {stopwatch.ElapsedMilliseconds} ms");
            Console.WriteLine($"ket thuc chương trình");
            Console.ReadLine();


        }





        //public static void demoThread()
        //{

        //    for (int i = 0; i < 5; i++)
        //    {

        //        //neu dat o ngoai nay thi chay mat 5s
        //        //Console.WriteLine("i");
        //        //Thread.Sleep(1000);

        //        Thread.Sleep(1000);
        //        //neu dat o ngoai nay thi chay mat tam ~1s: kieu tao ra 10 luong rieng de chay
        //        Thread t = new Thread(() =>
        //        {
        //            ///nhưng mà có 1 vấn đề là cac I xử lí bì trùng nhau vì chay nhanh quá
        //            Console.WriteLine(i);


        //        });
        //        t.Start();



        //    }



        //}



    }






}
