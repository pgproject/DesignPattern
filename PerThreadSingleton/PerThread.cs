using System.Threading;

namespace PerThreadSingleton
{
    public sealed class PerThread
    {
        private static ThreadLocal<PerThread> m_threadInstance = new ThreadLocal<PerThread>(() => new PerThread());

        public static PerThread Instance => m_threadInstance.Value;
            
        public int Id;    
        private PerThread()
        {
            Id = Thread.CurrentThread.ManagedThreadId;
        }
        
    }
}