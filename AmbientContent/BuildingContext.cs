using System;
using System.Collections.Generic;
using System.IO;

namespace AmbientContent
{
    public sealed class BuildingContext : IDisposable
    {
        public int WallHeight;
        private static Stack<BuildingContext> m_stack = new Stack<BuildingContext>();

        static BuildingContext()
        {
            m_stack.Push(new BuildingContext(0));    
        }

        public BuildingContext(int wallHeight)
        {
            WallHeight = wallHeight;
            m_stack.Push(this);
        }

        public static BuildingContext Current => m_stack.Peek();
        
        public void Dispose()
        {
            if (m_stack.Count > 1)
            {
                m_stack.Pop();
            }
        }
        
    }
}