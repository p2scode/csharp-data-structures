namespace DataStructures;
public class DynamicArray<T>
{
    private T[] _items = new T[4];

    public int Count { get; private set; }
    public int Capacity => _items.Length;

    public void Add(T item)
    {
        // TODO 1: Dizi doluysa iki kat büyük bir dizi aç ve elemanları kopyala

        if (Count == Capacity) 
        {

            T[] yeniDizi = new T[Capacity * 2];
        

            for (int i = 0; i < _items.Length; i++) 
            {
                yeniDizi[i] = _items[i];
            }

            _items = yeniDizi;

        }

        // TODO 2: item'ı sıradaki boş yer koy ve Count'u arttır
        _items[Count] = item;
        Count++;

    }

    public T this[int index]
    {
        get
        {
            // TODO 3: index geçersizse ArgumentOutOfRangeException fırlat

            if (index < 0 || index >= Count)
            {
                throw new ArgumentOutOfRangeException(nameof(index));
            }
            // TODO 4: Elemanı döndür
            return _items[index];
        }
    }
}