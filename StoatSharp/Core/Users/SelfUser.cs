namespace StoatSharp;


public class SelfUser : User
{
    public string? ProfileBio { get; internal set; }

    public Attachment? Background { get; internal set; }

    internal SelfUser(StoatClient client, UserJson model)
        : base(client, model)
    {
        if (model.Profile == null)
            return;

        ProfileBio = model.Profile.Content;
        Background = Attachment.Create(client, model.Profile.Background);
    }


    internal new SelfUser Clone()
    {
        return (SelfUser)this.MemberwiseClone();
    }
}