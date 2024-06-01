namespace Q1_WindowsService;

public sealed class EmailSettings
{
    /// <summary>
    /// The display name of sender
    /// </summary>
    public string FromName { get; set; }

    /// <summary>
    /// The sender email address
    /// </summary>
    public string FromAddress { get; set; }

    /// <summary>
    /// The display name of recipient
    /// </summary>
    public string ToName { get; set; }

    /// <summary>
    /// The recipient email address
    /// </summary>
    public string ToAddress { get; set; }

    /// <summary>
    /// Sender Gmail Username, the part before @
    /// </summary>
    public string GmailUsername { get; set; }

    /// <summary>
    /// Sender Gmail Password, see <see href="https://medium.com/net-newsletter-by-waseem/episode-22-sending-emails-using-mailkit-and-gmail-in-net-6-9aa56c9b6c83">here for more details</see>
    /// </summary>
    public string GmailPassword { get; set; }
}