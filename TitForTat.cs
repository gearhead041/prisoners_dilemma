
class TitForTat : BasePlayer
{
  public bool MakeChoice(bool? lastPlay = null)
  {
    if (lastPlay != null)
    {
      if ((bool)lastPlay)
      {
        return true;
      }

      else
      {
        return false;
      }
    }
    return true;
  }

  public override string ToString()
  {
    return "TitForTat";
  }
}