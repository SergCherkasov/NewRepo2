namespace HW_9.ThreadsMethods
    {
    public class CustomThreads
    {
#pragma warning disable SA1404 // Code analysis suppression should have justification
        [System.Diagnostics.CodeAnalysis.SuppressMessage("StyleCop.CSharp.DocumentationRules", "SA1600:Elements should be documented", Justification = "<Pending>")]
#pragma warning restore SA1404 // Code analysis suppression should have justification
        public void RecThread()
        {
            Thread backgroundThread = new Thread(new ThreadStart(this.RecThread));

            backgroundThread.Start();

            var threadsCount = System.Diagnostics.Process.GetCurrentProcess().Threads.Count;

            Console.WriteLine($"Thread ID = {backgroundThread.ManagedThreadId}, ThreadsCount: {threadsCount.ToString()}");
        }
    }
}
