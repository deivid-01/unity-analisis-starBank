using MongoDB.Driver;
using MongoDB.Bson;
using UnityEngine;
public class DataBase
{
    #region Propierties

    #region Config
    private const string MONGO_URI = "mongodb://root:root@starbankdb-shard-00-00-7zk06.mongodb.net:27017,starbankdb-shard-00-01-7zk06.mongodb.net:27017,starbankdb-shard-00-02-7zk06.mongodb.net:27017/test?ssl=true&replicaSet=starbankdb-shard-0&authSource=admin&retryWrites=true&w=majority";
    private const string DATABASE_NAME = "maindb";

    #region Collections 
    string nameCollecBrchOfc="branchOffices";
    string nameCollecNPeople="clt-natural";
    string nameCollectCompany="clt-company";
    #endregion

    #endregion

    private MongoClient client;
    private IMongoDatabase db;
    #endregion 

    #region Getters and Settters
    public IMongoDatabase Db { get => db; set => db = value; }
    public string NameCollecBrchOfc { get => nameCollecBrchOfc; set => nameCollecBrchOfc = value; }
    public string NameCollecNPeople { get => nameCollecNPeople; set => nameCollecNPeople = value; }
    public string NameCollectCompany { get => nameCollectCompany; set => nameCollectCompany = value; }
    #endregion

    #region Turn On/Off DataBase
    public void Init ()
    {
        client = new MongoClient ( MONGO_URI );
        db = client.GetDatabase ( DATABASE_NAME );
    }
    public void ShutDown ()
    {
        client = null;
        db = null;
    }
    #endregion

    #region CRUD   

    public T FindDocByIdNumber<T> ( string nameCollection , string id ) {

        try
        {
            return db.GetCollection<T> ( nameCollection ).Find ( Builders<T>.Filter.Eq ( "iD" , id ) ).First ();
        }
        catch {
            return default ( T );
        }
    }
    public void InsertDoc<T> ( string nameCollection , T doc ) => db.GetCollection<T> ( nameCollection ).InsertOne ( doc );
    public void UpdateDoc<T> ( string nameCollection , ObjectId id , T doc ) => db.GetCollection<T> ( nameCollection ).ReplaceOne ( new BsonDocument ( "_id" , id ) , doc , new UpdateOptions { IsUpsert = true } );
    public void DeleteDoc<T> ( string nameCollection , ObjectId id ) => db.GetCollection<T> ( nameCollection ).DeleteOne ( Builders<T>.Filter.Eq ( "_id" , id ) );
    #endregion

    #region Extended version

        
 }
    /*
    public void InsertDoc<T> ( string nameCollection , T doc ) {
        var collection=db.GetCollection<T>(nameCollection);
        collection.InsertOne ( doc );
    }

    public void UpdateDoc<T> ( string nameCollection , ObjectId id , T doc ) {
            
        
        var collection =db.GetCollection<T>(nameCollection);
        
        var result = collection.ReplaceOne( new BsonDocument("_id",id),doc, new UpdateOptions{ IsUpsert = true} );
    }

    

    
    public void DeleteDoc<T> ( string nameCollection , ObjectId id ) {
        var collection = db.GetCollection<T>(nameCollection);

        var filter = Builders<T>.Filter.Eq("_id",id);
        collection.DeleteOne ( filter );
    }

    */
    #endregion
