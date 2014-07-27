using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital
{
    class doctor
    {
        String id, name, lname, tel, address, e_area, b_date, salary, h_name, h_location, image;
        public doctor(String id, String name, String lname, String tel, String address,
            String e_area, String h_name, String h_location, String image)
        {
            this.id = id;
            this.name = name;
            this.lname = lname;
            this.tel = tel;
            this.address = address;
            this.e_area = e_area;
            this.h_name = h_name;
            this.h_location = h_location;
            this.image = image;
        }

        public string ID {
            get { return id; }
            set {id = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string LName
        {
            get { return lname; }
            set { lname = value; }
        }
        public string Tel
        {
            get { return tel; }
            set { tel = value; }
        }
        public string Address
        {
            get { return address; }
            set { address = value; }
        }
        public string E_area
        {
            get { return e_area; }
            set { e_area = value; }
        }
        public string B_date
        {
            get { return b_date; }
            set { b_date = value; }
        }
        public string Salary
        {
            get { return salary; }
            set { salary = value; }
        }
        public string H_name
        {
            get { return h_name; }
            set { h_name = value; }
        }
        public string H_location
        {
            get { return h_location; }
            set { h_location = value; }
        }
        public string Image
        {
            get { return image; }
            set { image = value; }
        }
    }
}
