using KwikKwekSnack.Data;

public class Program
{
    static void Main(string[] args)
    {

        using (var context = new SnackContext())
        {

            //InsertWoning(context); //Insert woning id 4 
            //InsertData(context);
            //InsertRelatedData(context);//voegt bewoners toe aan woning id 4
            //UpdateRelatedData(context);
        }
        //DisconnectedUpdateVoorbeeld1();//update bewoners in woning id 4
    }
}
