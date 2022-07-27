using System;

namespace DatingProfile
{ 
  class Profile {
    // Fields
    private string name;
    private int age;
    private string city;
    private string country;
    private string pronouns;
    private string[] hobbies;

    // Constructor
    public Profile(string name, int age, string city, string country, string pronouns = "they/them") {
      this.name = name;
      this.age = age; 
      this.city = city;
      this.country = country;
      this.pronouns = pronouns;
    }

    // Properties


    // Methods 

    public string ViewProfile() {
      string listHobbies = "";
      foreach (string hob in hobbies) {
        listHobbies = listHobbies + "\n" + hob;
      }
      return $"{name} {age} {city} {country} {pronouns} {listHobbies}";
    }

    public void SetHobbies(string[] hobbies) {
      this.hobbies = hobbies;
    }

  }

}
