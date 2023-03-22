namespace lab_demo{
    public class Car{
        //Declare all fields, please indicate each field as private and explain that we do this to protect the data
        //and that it is called data hiding. You must use the getters in order to access the field data from outside the class.

        //Lets assume we work for Toyota and we want to make sure that all cars we make are Toyota (The superior car company)
        private const string MAKE = "Toyota";
        private string model;

        //Lets also create a field that will be used differently than the other fields
        //when it comes time to write the getters and setters. this will be an incrementing field
        private int totalOwners;

        public Car(string model){
            //Default Constructor
            this.model = model;
        }

        //Include the getters and setters for the fields (Minus a setter for the MAKE field)

        public string GetMake(){
            return MAKE;
        }

        public string GetModel(){
            return model;
        }

        public void SetModel(string model){
            this.model = model;
        }

        public int GetTotalOwners(){
            return totalOwners;
        }

        //The total owners field will be incremented each time a new owner is added
        public void AddOwner(){
            totalOwners++;
        }


        //Create a ToString method for them to print out the car information
        //BE SURE TO INCLUDE THE OVERRIDE KEYWORD
        public override string ToString(){
            return $"Make: {MAKE}, Model: {model}, Total Owners: {totalOwners}";
        }
    }
}