public class Program{
    
    public static void Main (static[] args){
        Haed1 myHaed1 = new Haed1();
        myHaed1.name = "นายทวี";
        myHaed1.surname = "ใจดีดี";
        myHaed1.ID_card_code = "153-698-4561237";
        PrintHaed1Infoemation(myHaed1);

        Head2 myHaed2 = new Head2();
        myHaed2.name = "นายยุทธดี";
        myHaed2.surname = "ตั้งใจเรียน";
        myHaed2.ID_card_code = "742-112-5687412";
        PrintHaed2Infoemation(myHaed2);

        Haed3 myHaed3 = new Haed3();
        myHaed3.name = "นายเจมส์";
        myHaed3.surname = "รักโรงเรียน";
        myHaed3.ID_card_code = "541-772-3215689";
        PrintHaed3Infoemation(myHaed3);

    }

    static void PrintHaed1Infoemation(Haed1 Haed1){
        Console.WriteLine("ชื่อ: {0}",Haed1.name);
        Console.WriteLine("นามสกุล: {0}",Haed1.surname);
        Console.WriteLine("รหัสบัตรประชาชน: {0}",Haed1.ID_card_code);
    }
    static void PrintHaed2Infoemation(Head2 Head2){
        Console.WriteLine("ชื่อ: {0}",Head2.name);
        Console.WriteLine("นามสกุล: {0}",Head2.surname);
        Console.WriteLine("รหัสบัตรประชาชน: {0}",Head2.ID_card_code);
    }
    static void PrintHaed3Infoemation(Haed3 Haed3){
        Console.WriteLine("ชื่อ: {0}",Haed3.name);
        Console.WriteLine("นามสกุล: {0}",Head3.surname);
        Console.WriteLine("รหัสบัตรประชาชน: {0}",Head2.ID_card_code);
    }
    
}



