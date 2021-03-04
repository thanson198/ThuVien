Imports System.Xml

Public Class Condition
	Public Shared Function CheckGUIEmptyAndGetQuery(parameter As Object, nameTable As String) As String
		Dim conditionString As String

		If parameter <> Nothing then
			conditionString = "[" + nameTable + "] = " + "@" + nameTable
		Else 
			conditionString = "1 = 1"
		End If

		Return conditionString 

	End Function

	Public Shared Function CheckGUIEmptyAndGetQueryAmbiguous(parameter As Object, nameTable As String) As String
		Dim conditionString As String

		If parameter <> Nothing then
			conditionString = "[tblSach]." + nameTable + " = " + "@" + nameTable
		Else 
			conditionString = "1 = 1"
		End If

		Return conditionString 

	End Function

	Public Shared Function CheckGUIRangeAndGetQuery(minParameter As Object, 
	                                                maxParameter As Object, 
	                                                nameMin As String, 
	                                                nameMax As String, 
	                                                nameTable As String) As String
		Dim conditionString As String

		If minParameter <> Nothing And maxParameter <> Nothing then
			conditionString = "[" + nameTable + "] BETWEEN " + "@" + nameMin + " AND " + "@" + nameMax
		ElseIf minParameter <> Nothing
				conditionString = "[" + nameTable + "] >= " + "@" + nameMin 
		ElseIf maxParameter <> Nothing
				conditionString = "[" + nameTable + "] <= " + "@" + nameMax 
			Else 
				conditionString = "1 = 1"
		End If

		Return conditionString

	End Function
End Class
