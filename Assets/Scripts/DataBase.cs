using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Proyecto26;


public class DataBase : MonoBehaviour
{
    
    class User {

        public string name;
        public int age;
        public User(string name, int age) {
            this.name = name;
            this.age = age;
        }
    }

    public static DataBase Instance;
    private void Awake()
    {
        Instance = this;
    }

    void Start()
    {
      
    }

   public  void CreateClient()
    {
        
        RestClient.Post(url: "https://analisis-firebase.firebaseio.com/.json", new User("david",22));

    }

    public void GetClient()
    {
        User user;
        string idUser="";

        RestClient.Get<User>("https://project-id.firebaseio.com/" + idUser + ".json").Then(response =>
        {
            user = response;
            
        });
    }


    public void LoadAccounts(dynamic id) {

    }
    public dynamic SearchClient(string userName, string pass)
    {
        //search in data base
        //si es una PersonaNatural 
        //crear persona natural con sus cuentas
        //si es una empresa
        //crear empresa con sus cuentas
        return null;
    }


    public void LoadBranchOfficeData() {

        //BranchOffice.Instance=new BranchOffice(dataFromDB)
    }

    public void DeleteClient(string id) {
        //Deletefrom Data base
    }






}

