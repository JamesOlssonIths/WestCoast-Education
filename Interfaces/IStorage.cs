namespace WestCoast_Education.Interfaces;

public interface IStorage<T>
{
    List<T> Read(string path);
    void Write(string path, List<T> data);
    void Add(string path, T item);
}