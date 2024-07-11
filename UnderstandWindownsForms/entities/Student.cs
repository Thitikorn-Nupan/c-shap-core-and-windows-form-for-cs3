namespace UnderstandWindownsForms.entities {

    // In C#, a structure is a value type data type.
    // *** It helps you to make a single variable hold related data of various data types.
    internal struct Body {
        public float weight;
        public float height;
    }

    internal class Student {
        private int? id; // ? it means nullable
        private string fullname;
        private int age;
        private Body body; /* Declare body of type Body *** note don't object create class */

        public Student(int id, string fullname, int age, float weight, float height) {
            this.id = id;
            this.fullname = fullname;
            this.age = age;
            body.weight = weight;
            body.height = height;
        }

        public int Id {
            get => id ?? 1; // Null Coalescing Operator (??) it means if null will give a 1
            set => id = value;
        }

        public string Fullname {
            get => fullname;
            set => fullname = value;
        }

        public int Age {
            get => age;
            set => age = value;
        }

        public override string ToString() {
            return $"{Id}, {Fullname} , {Age} , {body.weight} , {body.height}";
        }
    }
}