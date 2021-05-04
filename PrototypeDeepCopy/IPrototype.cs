namespace PrototypeDeepCopy
{
    public interface IPrototype<T>
    {
        T DeepCopy();
    }
}