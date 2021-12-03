'Ollie Foster 9K
'
'1) An array is a way of storing similar types of data in RAM (volitile memory). An array is one datatype and can only store a fixed amount of data.
'
'2) You need to specify the following when creating an array: the name of the array, the index (how big the array is) and what datatype the array is
'
'3) Advantages of using an array are: Static size, work well with FOR loops 
'   Disadvantages of using arrays are: Static size, Stored in RAM (volitile memory), Single dataype

Module Program
	Sub Main()
		'Define the variables arrays for use throughout the program
		'V2 - the index of the player and score variables has been updated from 10 to 20. An the loops have been updated from 1 To 10 to 1 To 20
		Dim player(20) As String
		Dim score(20) As Int16
		Dim choice As Int16 = 0
		Dim edit As String = ""
		Dim editScore As Int16 = 0
		'V2 - new variable added to allow the user to delete a player
		Dim delete As String = ""
		'Asks the user for data about which operation they would like to do
		Console.WriteLine("Please enter 1 for inputing data, 2 for displaying data, 3 for edditing data or 4 for deleting data. . . ")
		choice = Val(Console.ReadLine())
		'if they selected choice to be 1 then the use will input how many goals he player has scored and their name. This would then input into the array starting from 1 as it is wrong to for a 'zeroth' player
		'V2 - Updated to 20 players to allow the new maximum amount of players
		If choice = 1 Then
			For c=1 To 20
				Console.WriteLine("Please enter the name of the footballer . . . ")
				player(c) = Console.ReadLine()
				Console.WriteLine("Please enter how many goals they have scored . . . ")
				score(c) =Val(Console.ReadLine())
			Next
		End If
		'If the user selected option 2 then all the data from both arrays would b printed out in neat rows for the user to see.
		If choice = 2 Then
			Console.Clear()
			For c=1 To 20
				Console.WriteLine(player(c) & " " & score(c) & vbCrLf)
			Next
		End If
		
		'If the user chose option 3 then this would allow them to edit existing data in the arrays. The loop find the index of the array by comparing the name to the name inputted by the user.
		If choice = 3 Then
			Console.Clear()
			Console.WriteLine("Please enter the name of the footballer who you would like to change . . . ")
			edit = Console.ReadLine()
			For c=1 To 20
				If player(c) = edit Then
					Console.WriteLine("Please enter the updated number of goals . . . ")
					editScore = Console.ReadLine()
					score(c) = editScore
				End If
			Next
		End If
		
		'V2 - If the user chooses option 4 then this would allow the user to delete a player from the array. It sorts through the data and when it finds it, it will set the element to its default values.
		If choice = 4 Then
			Console.WriteLine("Please enter the name of the player to be deleted . . . ")
			delete = Console.ReadLine()
			For c=1 To 20
				If player(c) = delete Then
					player(c) = ""
					score(c) = 0
				End If
			Next
		End If

		Console.Write("Press any key to continue . . . ")
		Console.ReadKey(True)
	End Sub
End Module
