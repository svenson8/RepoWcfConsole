using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;


    //Klasy interfejsu WCF
public interface IData
{
    string Name { get; set; }
}

[DataContract]
public class Data1 : IData
{
    private string _name = "Hello from Data1";
    [DataMember]
    public string Name
    {
        get { return _name; }
        set { _name = value; }
    }
}

[DataContract]
public class Data2 : IData
{
    private string _name = "Hello from Data2";
    [DataMember]
    public string Name
    {
        get { return _name; }
        set { _name = value; }
    }
}

[DataContract]
[KnownType(typeof(Data1))]
[KnownType(typeof(Data2))]
public class Container
{
    [DataMember]
    public List<IData> Items { get; set; }

    public Container()
    {
        Items = new List<IData>();
        Items.Add(new Data1());
        Items.Add(new Data2());
    }
}



public class ContainerSvc : IContainerSvc
{
    public Container GetSomeData()
    {
        return new Container();
    }
}

