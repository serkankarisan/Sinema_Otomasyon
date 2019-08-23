﻿using BLL.Sinema.Repository.Service;
using Entities.Sinema.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PL.Sinema.UI
{
    public class Genel
    {
        public static RepositoryService Service = new RepositoryService();

        public static string Hash(string password)
        {
            var bytes = new UTF8Encoding().GetBytes(password);
            byte[] hashBytes;
            using (var algorithm = new System.Security.Cryptography.SHA512Managed())
            {
                hashBytes = algorithm.ComputeHash(bytes);
            }
            return Convert.ToBase64String(hashBytes);
        }

        public static string CheckUser(string UserName, string Password)
        {
            string hashPassword = Hash(Password);
            User user = Service.User.Select().Where(k => k.UserName == UserName).FirstOrDefault();
            string result = "0";
            if (user != null)
            {
                if (String.Compare(hashPassword, user.Password, false) == 0)
                {
                    if (String.Compare(UserName, user.UserName, false) == 0)
                    {
                        result = "1";
                    }
                    else
                    {
                        result = "err_username";
                    }
                }
                else
                {
                    result = "err_password";
                }
            }
            else
            {
                result = "err_username";
            }
            return result;
        }
    }
}