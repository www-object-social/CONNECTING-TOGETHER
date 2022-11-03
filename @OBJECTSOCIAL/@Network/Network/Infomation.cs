namespace Network;
public interface Infomation
{
    public Status Status { get; }
    public event Action Change;
    public event Action Ready;
}