//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from: Employees/PowersOfAttorney/EmployeePowerOfAttorney.proto
// Note: requires additional types generated from: PowersOfAttorney/PowerOfAttorney.proto
namespace Diadoc.Api.Proto.Employees.PowersOfAttorney
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"EmployeePowerOfAttorneyList")]
  public partial class EmployeePowerOfAttorneyList : global::ProtoBuf.IExtensible
  {
    public EmployeePowerOfAttorneyList() {}
    
    private readonly global::System.Collections.Generic.List<Diadoc.Api.Proto.Employees.PowersOfAttorney.EmployeePowerOfAttorney> _PowersOfAttorney = new global::System.Collections.Generic.List<Diadoc.Api.Proto.Employees.PowersOfAttorney.EmployeePowerOfAttorney>();
    [global::ProtoBuf.ProtoMember(1, Name=@"PowersOfAttorney", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<Diadoc.Api.Proto.Employees.PowersOfAttorney.EmployeePowerOfAttorney> PowersOfAttorney
    {
      get { return _PowersOfAttorney; }
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"EmployeePowerOfAttorney")]
  public partial class EmployeePowerOfAttorney : global::ProtoBuf.IExtensible
  {
    public EmployeePowerOfAttorney() {}
    
    private Diadoc.Api.Proto.PowersOfAttorney.PowerOfAttorney _PowerOfAttorney;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"PowerOfAttorney", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public Diadoc.Api.Proto.PowersOfAttorney.PowerOfAttorney PowerOfAttorney
    {
      get { return _PowerOfAttorney; }
      set { _PowerOfAttorney = value; }
    }
    private bool _IsDefault;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"IsDefault", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public bool IsDefault
    {
      get { return _IsDefault; }
      set { _IsDefault = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"EmployeePowerOfAttorneyToUpdate")]
  public partial class EmployeePowerOfAttorneyToUpdate : global::ProtoBuf.IExtensible
  {
    public EmployeePowerOfAttorneyToUpdate() {}
    

    private Diadoc.Api.Proto.Employees.PowersOfAttorney.EmployeePowerOfAttorneyIsDefaultPatch _IsDefaultPatch = null;
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"IsDefaultPatch", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public Diadoc.Api.Proto.Employees.PowersOfAttorney.EmployeePowerOfAttorneyIsDefaultPatch IsDefaultPatch
    {
      get { return _IsDefaultPatch; }
      set { _IsDefaultPatch = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"EmployeePowerOfAttorneyIsDefaultPatch")]
  public partial class EmployeePowerOfAttorneyIsDefaultPatch : global::ProtoBuf.IExtensible
  {
    public EmployeePowerOfAttorneyIsDefaultPatch() {}
    
    private bool _IsDefault;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"IsDefault", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public bool IsDefault
    {
      get { return _IsDefault; }
      set { _IsDefault = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}