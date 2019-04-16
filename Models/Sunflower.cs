namespace FlowerShop {


  public class Sunflower : IBirthday
  {
    public int NumOfPetals {get; set;}

    public string Color {get; set;}

     public string Species {get; set;}

     public double StemLength {get; set;}
     public bool Thorny {get; set;}
    public bool Seeds {get; set;}

     public int Size {get; set;}

    public override string ToString() {
       return "a nice Sunflower";
    }
  }
}