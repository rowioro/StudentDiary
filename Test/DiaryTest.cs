using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using StudentDiary;

namespace Test
{
    [TestClass]
    public class Value
    {
        [TestMethod]
        public void PassByValueClass()
        {
            Diary diary = new Diary();
            diary.Name = "Jacek";

            setName(diary);

            Assert.AreEqual("Marcin", diary.Name);
        }

        private void setName(Diary diary)
        {
            diary.Name = "Marcinek";
        }
    }
}
