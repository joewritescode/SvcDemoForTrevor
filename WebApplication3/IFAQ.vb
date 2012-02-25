Imports System.ServiceModel
Imports System.ServiceModel.Web

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IFAQ" in both code and config file together.
<ServiceContract()>
Public Interface IFAQ

    <OperationContract()>
    <WebGet(BodyStyle:=WebMessageBodyStyle.Bare, _
            RequestFormat:=WebMessageFormat.Json, _
            ResponseFormat:=WebMessageFormat.Json)>
    Function HelloWorld(ByVal searchParm As String) As Monkeys

End Interface
