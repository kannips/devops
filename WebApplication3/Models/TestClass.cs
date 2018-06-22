using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication3.Controllers;

namespace WebApplication3.Models
{
    public class TestClass
    {
        int s;

        [Test]
        public void Addmethod()
        {
            int x = 10;
            int y = 20;
            s = x + y;
        } 

        [Test]
        public void Submethod()
        {
            int p = s - 10;
            Assert.AreEqual(p, 20);
        }

        [Test]
        public void TestDepartmentCreateRedirect()
        {
            var controller = new TestController();
            var actResult = controller.Index() as ViewResult;
            Assert.That(actResult.ViewName, Is.EqualTo("Index"));
        }
    }
}