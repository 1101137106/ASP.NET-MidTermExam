using KuasCore.Dao;
using KuasCore.Dao.Impl;
using KuasCore.Models;
using System;
using System.Collections.Generic;

namespace KuasCore.Services.Impl
{
    public class TxCourseService : ITxCourseService
    {

        public ICourseDao CourseDao { get; set; }

        public void ExecuteTxMethod()
        {
            Course Course1 = new Course();
            Course1.CourseID = "AAA";
            Course1.CourseName = "AAA";
            Course1.CourseDescription = "AAA";
            CourseDao.AddCourse(Course1);

            Course Course2 = new Course();
            Course2.CourseID = "BBB";
            Course2.CourseName = "BBB";
            Course2.CourseDescription = "BBB";
            CourseDao.AddCourse(Course2);

            Course dbCourse = CourseDao.GetCourseById("AAA");
            dbCourse.CourseName = "XXX";
            CourseDao.UpdateCourse(dbCourse);

            throw new Exception("Get an exception");
        }

    }

}
