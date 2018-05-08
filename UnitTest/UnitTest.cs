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

            lambda = new LambdaExpConditions<UserEntity>();
            lambda.AddAndWhere(false, u => u.Id != 1 && u.IsEnable == false, u => u.Id == 1 && u.IsEnable == false);
            Console.WriteLine("Where：" + lambda.Where());
            Console.WriteLine("=========================================================");
        }
    }
}
