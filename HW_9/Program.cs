using HW_9.ThreadsMethods;

CustomThreads ct = new CustomThreads();

ct.RecThread();

Thread.CurrentThread.Join();
