namespace InheritanceDemo.MyClasses;

internal class Team : Sponsor
{
    private string teamName;

    public Team(string teamName)
    {
        this.teamName = teamName;
    }

    /// <Summary>
    /// Here we have used + to concate two strings owner and teamName in this method
    /// </Summary>
    public string printInfo()
    {
        return $"Concatenated String : {owner + teamName}";
    }
}
