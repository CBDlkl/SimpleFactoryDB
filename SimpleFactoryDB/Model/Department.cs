﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication5.Model
{
    //部门表
    public class Department
    {
        private int _id;

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }
        private string _name;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
    }
}