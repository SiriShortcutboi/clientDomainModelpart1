using System.Reflection.Metadata;
using System.Collections.Generic;

namespace CompanyManagement.Models;	

public class Client //new class gets curly braces, no activating ()
{
    public Guid Id {get; set;}//might go inside the constructor
    public string Name {get; set;}

    public string Email {get; set;}

    public DateTime CreatedOn {get; set;}

    private bool IsActive {get; set;}

    //constructor looks like class declare without the word class
    public Client(string name, string email) //constructor
    {   //this is where objects are passed in for you to say
        //Name = name; or thisName = name 
        Name = name;
        Email = email;
        Id = Guid.NewGuid();
        CreatedOn = DateTime.Now;
        IsActive = true;
    }

    public Client(string name, string email, Guid id,
     DateTime createdOn, bool isActive)
    {
        Name = name;
        Email = email;
        Id = id;
        CreatedOn = createdOn;
        IsActive = isActive;

    }

    public string GetSummary()
    {
        string clientInfo = $"  Client: {Name} \nEmail: {Email}" +  
                $"\nStatus: {IsActive}, \nCreated: {CreatedOn} ";
        return clientInfo;
    }

    public void Deactivate()
    {
        IsActive = false;
    }
}

public class ClientRepository()
{
    Namespace Services;
    

     Dictionary<Guid, Client> myClientDictionary = new Dictionary<int, string>();
    void addClient(Client client)
    {   
       myClientDictionary.Add(id, /* client*/);//find the right client ID by guid
            //i think i have to use a method like .add to find the
            // right one first and then call add to do it


    }



}
