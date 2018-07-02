@Code
    ViewData("Title") = "JQuerySample"
End Code

<script> //Global app setting
    $realta = {};
    //gcBaseUrl = "http://localhost:50771";
    gcBaseUrl = "https://localhost:44312";
    USERNAME = "R_BasicAuthToken";
    PASSWORD = "Realta.co.id";

    $realta.callService = function (pcUrl, poParam, peSuccessHandler, peErrorHandler) {
        return $.ajax({
            type: "POST",
            url: pcUrl,
            data: JSON.stringify(poParam),
            contentType: "application/json; charset=utf-8",
            dataType: "json",
            beforeSend: function (xhr) {
                xhr.setRequestHeader('Authorization', 'Basic ' + btoa(USERNAME + ":" + PASSWORD));
            },
            success: peSuccessHandler,
            error: peErrorHandler
        });
    }
</script>

<script> //Program specific script
    function btnGetList_click() {
        $realta.callService(
            gcBaseUrl + "/api/Test/GetList",
            {
                "piDataCount": 10
            },
            function (msg) {
                console.log(msg);
            },
            function (jqXHR, textStatus) {
                alert("Request failed: " + textStatus);
            }
        );
    }

    function btnGetRecord_click() {
        $realta.callService(
            gcBaseUrl + "/api/Test/GetRecord",
            {
                "cCompanyId": null,
                "iId": 2,
                "cString": "Item 2",
                "nDecimal": 0.2,
                "cDatee": null,
                "cTime": null,
                "lBoolean": true,
            },
            function (msg) {
                console.log(msg);
            },
            function (jqXHR, textStatus) {
                alert("Request failed: " + textStatus);
            }
        );
    }

    function btnAdd_click() {
        $realta.callService(
            gcBaseUrl + "/api/Test/Add",
            {
                "iId": 999,
                "cString": "Item 2",
                "nDecimal": 0.2,
                "lBoolean": true,
            },
            function (msg) {
                console.log(msg);
            },
            function (jqXHR, textStatus) {
                alert("Request failed: " + textStatus);
            }
        );
    }

    function btnEdit_click() {
        $realta.callService(
            gcBaseUrl + "/api/Test/Edit",
            {
                "iId": 999,
                "cString": "Item 999",
                "nDecimal": 99.9,
                "lBoolean": true,
            },
            function (msg) {
                console.log(msg);
            },
            function (jqXHR, textStatus) {
                alert("Request failed: " + textStatus);
            }
        );
    }

    function btnDelete_click() {
        $realta.callService(
            gcBaseUrl + "/api/Test/Delete",
            function (msg) {
                console.log(msg);
            },
            function (jqXHR, textStatus) {
                alert("Request failed: " + textStatus);
            }
        );
    }
</script>

<button type="button" onclick="btnGetList_click()">Get List</button>
<button type="button" onclick="btnGetRecord_click()">Get Record</button>
<button type="button" onclick="btnAdd_click()">Add</button>
<button type="button" onclick="btnEdit_click()">Edit</button>
<button type="button" onclick="btnDelete_click()">Delete</button>
