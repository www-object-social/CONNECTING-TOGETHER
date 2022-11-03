namespace Network.Software;
public class Infomation : Network.Infomation
{
    public Status Status => Microsoft.Maui.Networking.Connectivity.Current.NetworkAccess is NetworkAccess.Internet ? Network.Status.Online : Status.Offline;
    public event Action Change = null!;
    public event Action Ready = null!;

    public Infomation() {
        Microsoft.Maui.Networking.Connectivity.Current.ConnectivityChanged += (s, e) => this.Change?.Invoke();
        _ = Constructor().ConfigureAwait(false);
    }
    private async Task Constructor() {
        await Task.Delay(10);
        this.Ready?.Invoke();
    }
}