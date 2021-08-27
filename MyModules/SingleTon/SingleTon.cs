using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyModules.SingleTon
{
    public class UserInfoSingleton
    {
        private string userid;
        private string username;
        private static UserInfoSingleton instance = null;

        private UserInfoSingleton()
        {
        }

        // 변수를 이용한 방법1
        public static UserInfoSingleton Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new UserInfoSingleton();
                }
                return instance;
            }
        }

        // 변수를 이용한 방법2
        public static UserInfoSingleton GetInstance()
        {
            if (instance == null)
            {
                instance = new UserInfoSingleton();
            }
            return instance; 
        }

        public string Userid
        {
            get
            {
                return this.userid;
            }
            set
            {
                this.userid = value; 
            }
        }

        public string UserName
        {
            get
            {
                return this.username;
            }
            set
            {
                this.username = value;
            }
        }
    }
}
