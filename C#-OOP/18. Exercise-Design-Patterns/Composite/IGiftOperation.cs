namespace Composite
{
    public interface IGiftOperation
    {
        void Add(Gift gift);

        void Remove(Gift remove);

        void Update(Gift gift);
    }
}
