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
                $("#btnGetRecord").prop('disabled', false);
                $("#btnAdd").prop('disabled', false);
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
                "iId": 2
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
                "cString": "Item UNKNOWN",
                "nDecimal": 0.2,
                "lBoolean": true,
            },
            function (msg) {
                console.log("add id 999");
                $("#btnEdit").prop('disabled', false);
                $("#btnDelete").prop('disabled', false);
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
                console.log("edit item 999");
            },
            function (jqXHR, textStatus) {
                alert("Request failed: " + textStatus);
            }
        );
    }

    function btnDelete_click() {
        $realta.callService(
            gcBaseUrl + "/api/Test/Delete",
            {
                "iId": 999
            },
            function (msg) {
                console.log("delete id 999");
                $("#btnEdit").prop('disabled', true);
                $("#btnDelete").prop('disabled', true);
            },
            function (jqXHR, textStatus) {
                alert("Request failed: " + textStatus);
            }
        );
    }
</script>

<div class="col-sm-12">
    <button type="button" class="btn" onclick="btnGetList_click()">Get List</button>
    <button type="button" class="btn" id="btnGetRecord" onclick="btnGetRecord_click()" disabled>Get Record</button>
    <button type="button" class="btn" id="btnAdd" onclick="btnAdd_click()" disabled>Add</button>
    <button type="button" class="btn" id="btnEdit" onclick="btnEdit_click()" disabled>Edit</button>
    <button type="button" class="btn" id="btnDelete" onclick="btnDelete_click()" disabled>Delete</button>
</div>
