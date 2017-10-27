using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client
{
    public class Cookie
    {
        //登录

        public bool Login(LoginEntity login)
        {
            //首先检测是否存在已登录的cookie
            //如果不存在跳转到登录页面，否则根据cookie的过期时间来判断是否有必要跳转
            //请求数据库登录信息
            if (true)
            {
                //如果登录成功，写入cookie并创建与该cookie关联的用户信息
                // cookie的 Guid 关联用户账户密码
            }
            return true;
        }
    }
}
