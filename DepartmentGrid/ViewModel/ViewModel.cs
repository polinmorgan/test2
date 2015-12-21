using DepartmentGrid.DataAccess;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows.Input;

namespace DepartmentGrid.ViewModel
{
    public class ViewModelView : INotifyPropertyChanged
    {
        private DataAccess.DeparrmentService DS = new DataAccess.DeparrmentService();
        public ViewModelView()
        {
            this.LoadData();
            _DeleteDepartments = new DeleteDepartment(this);
            _addDepartments = new AddDepartment(this);

            NewDepartment = new Department.Polina_Department();
        }

        private void LoadData()
        {
            this.Departaments = this.DS.getDapertmentForComboBox();
            this.GridDepartaments = this.DS.getDapertmentForGrid();
            DataGridCollection = CollectionViewSource.GetDefaultView(GridDepartaments);
        }

        private ICollectionView _dataGridCollection;
        public ICollectionView DataGridCollection
        {
            get { return _dataGridCollection; }
            set { _dataGridCollection = value;
                this.OnPropertyChanged("DataGridCollection");
            }
        }



        private void FilterCollection()
        {
            if (_dataGridCollection != null)
            {
                
                if (CurrentDeportament.Department_id != -1)
                    _dataGridCollection.Filter = new Predicate<object>(item => ((DataAccess.DepartmentGrid)item).Data.Department_id == CurrentDeportament.Department_id);
                else _dataGridCollection.Filter = null;
                _dataGridCollection.Refresh();
            }
        }

        private Department.Polina_Department _NewDepartment;
        public Department.Polina_Department NewDepartment {
            get { return this._NewDepartment; }
            set { this._NewDepartment = value;
                this.OnPropertyChanged("NewDepartment");
            }
        }
        private Department.Polina_Department _CurrentDeportament;
        public Department.Polina_Department CurrentDeportament
        {
            get { return this._CurrentDeportament; }

            set
            {
                if (value != null)
                {
                    _CurrentDeportament = value;
                    this.OnPropertyChanged("CurrentDeportament");

                    FilterCollection();
                }


            }
        }
        public event PropertyChangedEventHandler PropertyChanged;

        private IEnumerable<Department.Polina_Department> _Departaments;
        public IEnumerable<Department.Polina_Department> Departaments
        {

            get { return this._Departaments; }
            set
            {
                this._Departaments = value;
                this.OnPropertyChanged("Departaments");

            }
        }
        private IEnumerable<DataAccess.DepartmentGrid> _GridDepartaments;

        public IEnumerable<DataAccess.DepartmentGrid> GridDepartaments
        {

            get { return this._GridDepartaments; }
            set
            {
                this._GridDepartaments = value;
                this.OnPropertyChanged("GridDepartaments");
             

            }
        }


        private void OnPropertyChanged(String PropertyName)
        {

            if (this.PropertyChanged != null)
            {
                this.PropertyChanged(this, new PropertyChangedEventArgs(PropertyName));
            }
        }
        public void DelDepart()
        {
            var list = GridDepartaments.Where(s => s.IsSelected == true).ToList();
            this.DS.DeleteDepartments(list);
            LoadData();
        }
        public void NewDepart() {
            if (NewDepartment != null)
                this.DS.SaveDepartment(NewDepartment);
            LoadData(); 
        }

        private DeleteDepartment _DeleteDepartments;
         public DeleteDepartment DeleteDepartments { get { return this._DeleteDepartments; } }
        private AddDepartment _addDepartments;
        public AddDepartment AddDepartments { get { return this._addDepartments; } }
    }
        public class DeleteDepartment : ICommand
        {
            private DepartmentGrid.ViewModel.ViewModelView vm;
            public DeleteDepartment(ViewModelView _vm)
            {
               this.vm =_vm;
                this.vm.PropertyChanged += (s, e) =>
                    {

                        if (this.CanExecuteChanged != null)
                            CanExecuteChanged(this, new EventArgs());
                    };
            }

            public event EventHandler CanExecuteChanged;

            public bool CanExecute(object parameter)
            {
                return this.vm.GridDepartaments.Where(d=>d.IsSelected==true) != null;
            }

            public void Execute(object parameter)
            {
                this.vm.DelDepart();
            }
        }
    public class AddDepartment : ICommand
    {
        private DepartmentGrid.ViewModel.ViewModelView vm;
        public AddDepartment(ViewModelView _vm)
        {
            this.vm = _vm;
            this.vm.PropertyChanged += (s, e) =>
            {

                if (this.CanExecuteChanged != null)
                    CanExecuteChanged(this, new EventArgs());
            };
        }

        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return this.vm.NewDepartment.Department_name != "";
        }

        public void Execute(object parameter)
        {
            this.vm.NewDepart(); 
        }
    }

}





