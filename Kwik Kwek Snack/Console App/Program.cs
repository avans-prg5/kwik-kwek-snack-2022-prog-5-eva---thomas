using Console_App;
using KwikKwekSnack.Data;
using Microsoft.IdentityModel.Tokens;
using System.Runtime.CompilerServices;

public class Program
{
    static void Main(string[] args)
    {

        new MainController();




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
   
