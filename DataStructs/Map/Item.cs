
namespace DataStructs.Map
{
    public record Item<TKey, TValue>(TKey? Key, TValue Value)
    {
        public override int GetHashCode()
        {
            return Key.GetHashCode();
        }
    }
}
