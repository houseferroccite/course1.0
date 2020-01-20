using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Course_project.Method_s_for_quicly_use_DB
{
    class dbHelper
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="Position">Можно взять через текстовое поле</param>
        /// <returns></returns>
        public static int inserPosition(string Position)
        {
            //Fill list input parametrs
            List<Parametrs_command> listParams = new List<Parametrs_command>
            {
                new Parametrs_command("@position",Position)
            };

            //Run command and get value ID insert types
            return DB.changeData("InsertPosition", "Т_Должность", listParams, new Parametrs_command("@ID", SqlDbType.Int));
        }

        public static int Insert_Login(string Login, int password)
        {
            //Fill list input parametrs
            List<Parametrs_command> listParams = new List<Parametrs_command>
            {
                new Parametrs_command("@Acces_rights",Login),
                new Parametrs_command("@Password",password)
            };

            //Run command and get value ID insert types
            return DB.changeData("InsertLogin", "Login", listParams, new Parametrs_command("@ID", SqlDbType.Int));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Position">Можно взять через текстовое поле</param>
        /// <returns></returns>
        public static void DeletePosition(int id_Position)
        {
            //Fill list input parametrs
            List<Parametrs_command> listParams = new List<Parametrs_command>
            {
                new Parametrs_command("@ID",id_Position,SqlDbType.Int)
            };

            //Run command and get value ID insert types
            DB.changeData("DelPosition", "Т_Должность", listParams);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Position">Можно взять через текстовое поле</param>
        /// <returns></returns>
        public static void UpdatePosition(string Position, int id)
        {
            //Fill list input parametrs
            List<Parametrs_command> listParams = new List<Parametrs_command>
            {
                new Parametrs_command("@Position",Position),
                new Parametrs_command("@IDPosition",id)
            };

            //Run command and get value ID insert types
            DB.changeData("UpdatePosition", "Т_Должность", listParams);
        }
         
        public static byte[] massivebyte_photo(string fileName)
        {
                byte[] image_byte;
                using (FileStream fs = new FileStream(fileName, FileMode.Open))
                {
                    image_byte = new byte[fs.Length];
                    fs.Read(image_byte, 0, image_byte.Length);
                }
                return image_byte;
            
        }
        public static int InsertClient(string ФИО, string Адрес, string Реквизиты_банка, string filePhoto )
        {
            //Fill list input parametrs
            List<Parametrs_command> listParams = new List<Parametrs_command>
            {
                new Parametrs_command("@Фио",ФИО),
                new Parametrs_command("@Адрес",Адрес),
                new Parametrs_command("@Реквизиты_банка",Реквизиты_банка),
                new Parametrs_command("@Фото",massivebyte_photo(filePhoto), SqlDbType.Image)
            };
            //Run command and get value ID insert types
            return DB.changeData("InsertClient", "Т_Клиент", listParams, new Parametrs_command("@ID", SqlDbType.Int));
        }
        public  static int InsertDogovor(string Название_договора,string Куратор_проекта,string ФИО_Клиента, DateTime Дата_составления, string Язык_разработки, int Колво_дней, DateTime Плановая_дата)
        {
            //Fill list input parametrs
            List<Parametrs_command> listParams = new List<Parametrs_command>
            {
                new Parametrs_command("@Название_договора",Название_договора),
                new Parametrs_command("@Куратор_проекта",Куратор_проекта),
                new Parametrs_command("@ФИО_Клиента",ФИО_Клиента),
                new Parametrs_command("@Дата_составления", Дата_составления),
                new Parametrs_command("@Язык_разработки", Язык_разработки),
                new Parametrs_command("@Колво_дней",Колво_дней),
                new Parametrs_command("@Плановая_дата",Плановая_дата)
            };
            //Run command and get value ID insert types
            return DB.changeData("InsertDogovora", "Т_Договора", listParams, new Parametrs_command("@ID", SqlDbType.Int));
        }

        public static void UpdateClient(string ФИО, int IDClienta, string Адрес, string Реквизиты_банка,string filePhoto)
        {

            //Fill list input parametrs
            List<Parametrs_command> listParams = new List<Parametrs_command>
            {
                new Parametrs_command("@ФИО",ФИО),
                new Parametrs_command("@IDClienta",IDClienta),
                new Parametrs_command("@Адрес",Адрес),
                new Parametrs_command("@Реквизиты_банка",Реквизиты_банка),
                new Parametrs_command("@Фото",massivebyte_photo(filePhoto), SqlDbType.Image)
            };

            //Run command and get value ID insert types
            DB.changeData("UpdateClient", "Т_Клиент", listParams);
        }
    }
}
