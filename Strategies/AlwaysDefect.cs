
class AlwaysDefect : BasePlayer
{
  public bool MakeChoice(bool? lastPlay = null)
  {
    return false;
  }

  public override string ToString()
  {
    return "AlwaysDefect";
  }
}