namespace FlowerShop {


  public class Rose : IBirthday
  {
  public int NumOfPetals {get; set;}

    public string Color {get; set;}

     public bool Stem {get; set;}

     public string Species {get; set;}

     public double StemLength {get; set;}

     public bool thorny {get; set;}
     public int Size {get; set;}

    public bool Aromatic {get; set;}
  
    public override string ToString()
    {
          return "a bountiful rose";
    }

  }
}