using System.Diagnostics;
using System.Windows.Input;

namespace MauiFrameApp
  {
  public class MainPageViewModel
    {

    public IList<Monkey> Monkeys { get; set; }

    public ICommand TestCommand => new Command(() => Debug.WriteLine("Command successful"));

    public MainPageViewModel()
      {
      Monkeys = new List<Monkey>();

      Monkeys.Add(new Monkey
        {
        Name = "Baboon",
        Location = "Africa & Asia"
        });

      Monkeys.Add(new Monkey
        {
        Name = "Seated Monkey",
        Location="Unknown"

        });

      Monkeys.Add(new Monkey
        {
        Name = "Capuchin Monkey",
        Location = "Central & South America"
        });

      Monkeys.Add(new Monkey
        {
        Name = "Blue Monkey",
        Location = "Central and East Africa"
        });
      }

  }
  }
