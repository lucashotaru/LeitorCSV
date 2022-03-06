namespace LeitorCBF.LeitorCSV.Repository
{
    public interface ILeitorCSVModelRepository
    {
        bool Equals(object obj);
        int GetHashCode();
        string ToString();
    }
}