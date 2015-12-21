using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Department; 

namespace DepartmentGrid.DataAccess
{
    public class DepartmentGrid
    {
        public Department.Polina_Department Data { get; set; }
        public bool IsSelected { get; set; }
    }
    //public class DepartmentComboBox
    //{
    //    public Department.Polina_Department Data { get; set; }
    //    //public bool IsSelected { get; set; }
    //}
    public class DeparrmentService
    {
        
        

            public IEnumerable<DepartmentGrid> getDapertmentForGrid()
            {
            List<DepartmentGrid> dl = new List<DepartmentGrid>();
            using (var context = new DepartmentEntities())
            {
                var result = context.Polina_Department.ToList();
                foreach (var r in result)
                    dl.Add(new DepartmentGrid { Data = r, IsSelected = false }); 
                    return dl;
                }

            }

        public IEnumerable<Department.Polina_Department> getDapertmentForComboBox()
        {
            List<Department.Polina_Department> dl = new List<Department.Polina_Department>();
            using (var context = new DepartmentEntities())
            {
                dl.Add(new Department.Polina_Department { Department_id = -1, Department_name ="ALL", Department_phone = " " });

                var result = context.Polina_Department.ToList();
                //dl.Add(new DepartmentComboBox { Data = new Department.Polina_Department { Department_id = -1, Department_name = "All", Department_phone = "" } });
                foreach (var r in result)
                    dl.Add(new Department.Polina_Department { Department_id=r.Department_id,Department_name=r.Department_name, Department_phone=r.Department_phone});
                return dl;
            }

        }
        public void SaveDepartment(Department.Polina_Department depart)
            {

                using (var context = new Department.DepartmentEntities())
                {
                    context.Polina_Department.Add(depart);
                    context.SaveChanges();
                }

            }

            public void DeleteDepartments(IEnumerable<DepartmentGrid> depart)
            {

            
            using (var context = new Department.DepartmentEntities())
                {
                if (context.Polina_Department.Count()==0)
                    return;
                foreach (var d in depart)
                    context.Polina_Department.Remove(context.Polina_Department.Where(p => p.Department_id == d.Data.Department_id).SingleOrDefault()); 
                    context.SaveChanges();
                }

            }
        }


   
}
