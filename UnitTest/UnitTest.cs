using System;
using System.Linq;
using LambdaToSQL;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTest
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void TestMethod()
        {
            LambdaExpConditions<UserEntity> lambda = new LambdaExpConditions<UserEntity>();

            lambda.Add(u => u.Where(o => o.Id == 1 && o.IsEnable == false && o.Birthday > new DateTime(2017, 10, 12)).OrderByDescending(o => o.Id));

            Console.WriteLine("Where：" + lambda.Where() + "，OrderBy：" + lambda.OrderBy());
            Console.WriteLine("=========================================================");

            UserEntity user = new UserEntity
            {
                Id = 1
            };

            lambda = new LambdaExpConditions<UserEntity>();
            lambda.AddAndWhere(() => { return user.Id > 1; }, u => u.UserName.Contains("大师兄") && u.IsEnable == false, u => u.UserName == "大师兄" && u.IsEnable == false);
            lambda.AddOrderBy(u => u.Id);
            Console.WriteLine("Where：" + lambda.Where() + "，OrderBy：" + lambda.OrderBy());
            Console.WriteLine("=========================================================");
        }
    }
}
