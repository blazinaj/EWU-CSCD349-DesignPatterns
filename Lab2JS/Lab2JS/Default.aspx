<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Age At Graduation</title>
    <style>
        table {
            font-family: Arial, sans-serif;
        }
        td, th {
            border: none;
            text-align: right;
            padding: 8px;
        }
        th {
            text-align: left;
        }
        .submit {
            text-align: right;
        }
        .banner {
            width: 100px;
            height: 1px;
        }
    </style>
</head>
<body>
    <form id="dateForm" runat="server">
        <img src="banner.jpg" style="width:90vw" />
        <div>
            <h1>Using Javascript..</h1>
            <div>The Current Date is: </div>
            <div id="date"></div>
            <br />
            <br />
            <div id="Prompt">How old will you be when you graduate?</div>
            <br />
            <br />
            <div id="Prompt2">Enter your dates:</div>
            <br />
            <table border="0">
                <thead>
                    <tr>
                        <th>Birthdate:</th>
                        <th>Graduation date:</th>
                    </tr>
                </thead>
                <tbody>
                    <tr>
                        <td>Month: <input type="number" id="birthMonth" /></td>
                        <td>Month: <input type="number" id="gradMonth" /></td>
                    </tr>
                    <tr>
                        <td>Day: <input type="number" id="birthDay" /></td>
                        <td>Day: <input type="number" id="gradDay" /></td>
                    </tr>
                    <tr>
                        <td>Year: <input type="number" id="birthYear" /></td>
                        <td>Year: <input type="number" id="gradYear" /></td>
                    </tr>
                </tbody>
            </table>
            <br />
            <input id="ageButton" type="button" onclick="calculateAge()" value="Calculate Age" />
            <br />
            <br />
            <label>Output:</label>
            <br />
            <br />
            <label id="AgeLabel">Age Will Dispay Here..</label>


        </div>
    </form>

    <script>

        var date = new Date();
        document.getElementById("date").innerHTML = date;

        function getServerDate() {
            $.ajax({
                type: "POST",
                url: 'default.aspx/GetDate',
                contentType: "application/json; charset=utf-8",
                dataType: "json",
                success: function (results) {
                    document.getElementById("serverDate").innerHTML = results.d;
                },
                error: function (err) {
                    alert(err.status + " = " + err.statusText);
                }
            })
        }

        function calculateAge() {
            var birthYear = document.getElementById("birthYear").value;
            var gradYear = document.getElementById("gradYear").value;

            var age = gradYear - birthYear;

            document.getElementById("AgeLabel").innerHTML = "You will be " + age.toString() + " years old when you graduate";
        }

    </script>
</body>
</html>
