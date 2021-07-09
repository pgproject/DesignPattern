using System;

namespace Bridge
{
    public class VectorRenderer : IRenderer
    {
        public void RendererCircle(float radius)
        {
            Console.WriteLine($"Drawing a circle of radius {radius}");
        }
    }
    
    public class RasterRenderer : IRenderer
    {
        public void RendererCircle(float radius)
        {
            Console.WriteLine($"Drawing pixels a circle with radius {radius}");

        }
    }
}