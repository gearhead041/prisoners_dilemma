class Joss : BasePlayer
{
  private bool Betrayed;
  public bool MakeChoice(bool? lastPlay = null)
  {
    if (lastPlay != null)
    {
      if (Betrayed)
      {
        return false;
      }

      if (!(bool)lastPlay)
      {
        Betrayed = true;
        return false;
      }

      if ((bool)lastPlay)
      {
        return true;
      }
    }

    return true;
  }
}