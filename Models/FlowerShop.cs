using System.Collections.Generic;

namespace FlowerShop

{
  public class FlowerShop
  {
    public string ShopName { get; set; }

    public string OpeningTime { get; set; }

    public string ClosingTime { get; set; }

    public List<Rose> Roses { get; set; } = new List<Rose>();

    public List<Delilah> Delilahs { get; set; } = new List<Delilah>();
    public List<Sunflower> Sunflowers { get; set; } = new List<Sunflower>();
    public List<Tulip> Tulips { get; set; } = new List<Tulip>();

    public List<IMothersDay> MakeMothersDayArrangement()
    {
      List<IMothersDay> arrangement = new List<IMothersDay>() {
          new Tulip() {Size = 2},
          new Tulip() {Size = 4},
          new Tulip() {Size = 3},
          new Delilah() {Size = 1},
          new Delilah() {Size = 8}
      };
      return arrangement;
    }


      public List<IBirthday> MakeBirthdayArrangement()
    {
      List<IBirthday> arrangement2 = new List<IBirthday>() {
          new Rose() {Size = 4},
          new Rose() {Size = 2},
          new Rose() {Size = 3},
          new Sunflower() {Size = 2},
          new Sunflower() {Size = 8},
      };

      return arrangement2;
    }


  }

}