//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Menu
{
    using System;
    using System.Collections.Generic;
    
    public partial class Dish
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Dish()
        {
            this.ClassMenus = new HashSet<ClassMenu>();
        }
    
        public int DishId { get; set; }
        public string DishName { get; set; }
        public double Protein { get; set; }
        public double Fats { get; set; }
        public double Carbohydrates { get; set; }
        public double Calories { get; set; }
        public double Weight { get; set; }
        public string MealTime { get; set; }
        public Nullable<double> Ca { get; set; }
        public Nullable<double> P { get; set; }
        public Nullable<double> Mg { get; set; }
        public Nullable<double> Fe { get; set; }
        public Nullable<double> B1 { get; set; }
        public Nullable<double> C { get; set; }
        public Nullable<double> A { get; set; }
        public Nullable<double> E { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ClassMenu> ClassMenus { get; set; }

        public override string ToString()
        {
            return DishName + "--" + Calories + " ккал";
        }
    }
}
